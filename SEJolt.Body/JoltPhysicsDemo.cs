using VRage.Utils;
using JoltPhysicsSharp;
using System.Numerics;

namespace Jolt;

public static class JoltPhysicsDemo
{
    public static MyLog Log { get; set; }
    private static int _frameCount = 0;

    private static PhysicsSystem _physicsSystem;
    private static BodyInterface _bodyInterface;
    private static JobSystem _jobSystem;
    private static BodyID _body1ID;
    private static BodyID _body2ID;
    private static bool _collisionDetected = false;

    public static void Initialize(MyLog log)
    {
        Log = log;
        Log.Info("JoltPhysicsDemo initializing with JoltPhysicsSharp...");

        try
        {
            // Initialize Jolt Physics Foundation
            if (!Foundation.Init(false))
            {
                Log.Error("Failed to initialize Jolt Physics Foundation");
                return;
            }

            // Create job system for multi-threaded physics
            _jobSystem = new JobSystemThreadPool();

            // Setup collision filtering
            SetupCollisionFiltering(out var objectLayerPairFilter, out var broadPhaseLayerInterface, out var objectVsBroadPhaseLayerFilter);

            // Create physics system with settings
            var settings = new PhysicsSystemSettings()
            {
                MaxBodies = 1024,
                MaxBodyPairs = 1024,
                MaxContactConstraints = 1024,
                NumBodyMutexes = 0,
                ObjectLayerPairFilter = objectLayerPairFilter,
                BroadPhaseLayerInterface = broadPhaseLayerInterface,
                ObjectVsBroadPhaseLayerFilter = objectVsBroadPhaseLayerFilter,
            };

            _physicsSystem = new PhysicsSystem(settings);
            _bodyInterface = _physicsSystem.BodyInterface;

            Log.Info("Jolt Physics engine initialized successfully!");

            // Create two physics objects on a collision course
            CreatePhysicsObjects();

            // Set up collision callbacks
            SetupCollisionCallbacks();

            Log.Info("Physics objects created and collision callbacks registered!");
        }
        catch (Exception ex)
        {
            Log.Error($"Error initializing JoltPhysicsDemo: {ex.Message}\n{ex.StackTrace}");
        }

        _frameCount = 0;
    }

    private static void SetupCollisionFiltering(
        out ObjectLayerPairFilterTable objectLayerPairFilter,
        out BroadPhaseLayerInterfaceTable broadPhaseLayerInterface,
        out ObjectVsBroadPhaseLayerFilterTable objectVsBroadPhaseLayerFilter)
    {
        ObjectLayer NonMoving = 0;
        ObjectLayer Moving = 1;
        BroadPhaseLayer NonMovingBP = 0;
        BroadPhaseLayer MovingBP = 1;

        // Create object layer pair filter (defines which layers can collide)
        objectLayerPairFilter = new ObjectLayerPairFilterTable(2);
        objectLayerPairFilter.EnableCollision(NonMoving, Moving);
        objectLayerPairFilter.EnableCollision(Moving, Moving);

        // Create broad phase layer interface (maps object layers to broad phase layers)
        broadPhaseLayerInterface = new BroadPhaseLayerInterfaceTable(2, 2);
        broadPhaseLayerInterface.MapObjectToBroadPhaseLayer(NonMoving, NonMovingBP);
        broadPhaseLayerInterface.MapObjectToBroadPhaseLayer(Moving, MovingBP);

        // Create object vs broad phase layer filter
        objectVsBroadPhaseLayerFilter = new ObjectVsBroadPhaseLayerFilterTable(broadPhaseLayerInterface, 2, objectLayerPairFilter, 2);
    }

    private static void CreatePhysicsObjects()
    {
        ObjectLayer Moving = 1;

        // Create first body (sphere moving towards second body)
        SphereShape shape1 = new(1.0f); // 1 meter radius sphere
        using (BodyCreationSettings bodySettings1 = new(shape1, new Vector3(-5, 0, 0), Quaternion.Identity, MotionType.Dynamic, Moving))
        {
            Body body1 = _bodyInterface.CreateBody(bodySettings1);
            _body1ID = body1.ID;
            _bodyInterface.AddBody(_body1ID, Activation.Activate);

            // Set linear velocity to move towards body 2
            _bodyInterface.SetLinearVelocity(_body1ID, new Vector3(10, 0, 0)); // Moving right at 10 m/s
        }

        Log.Info($"Body 1 created at position (-5, 0, 0) with velocity (10, 0, 0)");

        // Create second body (sphere stationary, will be hit by first body)
        SphereShape shape2 = new(1.0f); // 1 meter radius sphere
        using (BodyCreationSettings bodySettings2 = new(shape2, new Vector3(5, 0, 0), Quaternion.Identity, MotionType.Dynamic, Moving))
        {
            Body body2 = _bodyInterface.CreateBody(bodySettings2);
            _body2ID = body2.ID;
            _bodyInterface.AddBody(_body2ID, Activation.Activate);

            // Keep body 2 stationary initially
            _bodyInterface.SetLinearVelocity(_body2ID, Vector3.Zero);
        }

        Log.Info($"Body 2 created at position (5, 0, 0) (stationary)");
    }

    private static void SetupCollisionCallbacks()
    {
        // Register contact callbacks on the physics system
        _physicsSystem.OnContactValidate += OnContactValidate;
        _physicsSystem.OnContactAdded += OnContactAdded;
        _physicsSystem.OnContactPersisted += OnContactPersisted;
        _physicsSystem.OnContactRemoved += OnContactRemoved;
    }

    private static ValidateResult OnContactValidate(PhysicsSystem system, in Body body1, in Body body2, RVector3 baseOffset, in CollideShapeResult collisionResult)
    {
        // Allow all contacts
        return ValidateResult.AcceptAllContactsForThisBodyPair;
    }

    private static void OnContactAdded(PhysicsSystem system, in Body body1, in Body body2, in ContactManifold manifold, in ContactSettings settings)
    {
        if (!_collisionDetected)
        {
            _collisionDetected = true;
            Log.Info("*** COLLISION DETECTED! ***");
            Log.Info($"Body 1 collided with Body 2 at frame {_frameCount}");
            Log.Info($"Body 1 Position: {body1.Position}");
            Log.Info($"Body 2 Position: {body2.Position}");
        }
    }

    private static void OnContactPersisted(PhysicsSystem system, in Body body1, in Body body2, in ContactManifold manifold, in ContactSettings settings)
    {
        // Contact is persisting (bodies still in contact)
    }

    private static void OnContactRemoved(PhysicsSystem system, ref SubShapeIDPair subShapePair)
    {
        Log.Info("Contact was removed");
    }

    public static void Step()
    {
        _frameCount++;

        try
        {
            // Step the physics simulation
            if (_physicsSystem != null && _jobSystem != null)
            {
                const int cCollisionSteps = 1;
                _physicsSystem.Update(1.0f / 60.0f, cCollisionSteps, _jobSystem);
            }
        }
        catch (Exception ex)
        {
            Log.Error($"Error stepping physics: {ex.Message}");
        }

        // Log every 60 frames (roughly once per second at 60 FPS)
        if (_frameCount % 60 == 0)
        {
            Log.Info($"JoltPhysicsDemo running... Frame: {_frameCount}");

            try
            {
                if (_body1ID.IsValid && _body2ID.IsValid)
                {
                    // Get body positions and velocities through the body interface
                    Vector3 body1Pos = _bodyInterface.GetCenterOfMassPosition(_body1ID);
                    Vector3 body1Vel = _bodyInterface.GetLinearVelocity(_body1ID);

                    Vector3 body2Pos = _bodyInterface.GetCenterOfMassPosition(_body2ID);
                    Vector3 body2Vel = _bodyInterface.GetLinearVelocity(_body2ID);

                    Log.Info($"  Body 1 Position: {body1Pos}, Velocity: {body1Vel}");
                    Log.Info($"  Body 2 Position: {body2Pos}, Velocity: {body2Vel}");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error reading body state: {ex.Message}");
            }
        }
    }

    public static void Shutdown()
    {
        try
        {
            if (_physicsSystem != null)
            {
                if (_body1ID.IsValid)
                {
                    _bodyInterface.RemoveAndDestroyBody(_body1ID);
                }

                if (_body2ID.IsValid)
                {
                    _bodyInterface.RemoveAndDestroyBody(_body2ID);
                }

                _physicsSystem.Dispose();
                _physicsSystem = null;
            }

            if (_jobSystem != null)
            {
                _jobSystem.Dispose();
                _jobSystem = null;
            }

            Foundation.Shutdown();
        }
        catch (Exception ex)
        {
            Log.Error($"Error during shutdown: {ex.Message}");
        }

        Log.Info($"JoltPhysicsDemo shutdown complete. Total frames: {_frameCount}. Collision detected: {_collisionDetected}");
    }
}
