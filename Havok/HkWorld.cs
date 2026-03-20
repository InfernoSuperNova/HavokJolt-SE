using System.Runtime.InteropServices;
using VRage.Collections;
using VRageMath;

namespace Havok {
    public partial class HkWorld {
        public event Havok.HkEntityHandler EntityLeftWorld;
        public event Havok.HkEntityHandler OnRigidBodyActivated;
        public event Havok.HkEntityHandler OnRigidBodyDeactivated;
        public event Havok.HkEntityHandler OnRigidBodyAdded;
        public event Havok.HkEntityHandler OnRigidBodyRemoved;
        public bool Multithreading { get; set;  }
        public TimeSpan StepDuration { get;  }
        public HkBreakOffPartsUtil BreakOffPartsUtil { get;  }
        public HkJobThreadPool ThreadPool { get;  }
        public HkJobQueue JobQueue { get;  }
        public List<HkRigidBody> RigidBodies { get;  }
        public List<HkCharacterRigidBody> CharacterRigidBodies { get;  }
        public HashSetReader<HkRigidBody> ActiveRigidBodies { get;  }
        public Vector3 Gravity { get; set;  }
        public float DeactivationRotationSqrdA { get; set;  }
        public float DeactivationRotationSqrdB { get; set;  }
        public HkWorld(bool enableGlobalGravity, float broadphaseCubeSideLength, float contactRestingVelocity, bool enableMultithreading, int solverIterations) { /* Initialize Jolt Equivalent Here */ }
        public HkWorld(ref CInfo cInfo) { /* Initialize Jolt Equivalent Here */ }
        public void InitMultithreading(HkJobThreadPool threadPool, HkJobQueue jobQueue) => throw new NotImplementedException();
        public void Lock() => throw new NotImplementedException();
        public void Unlock() => throw new NotImplementedException();
        public void LockCriticalOperations() => throw new NotImplementedException();
        public void UnlockCriticalOperations() => throw new NotImplementedException();
        public void ExecutePendingCriticalOperations() => throw new NotImplementedException();
        public void StepSimulation(float deltaTime, bool multiThreaded) => throw new NotImplementedException();
        public bool InitMtStep(HkJobQueue jobQueue, float timeInSec) => throw new NotImplementedException();
        public bool FinishMtStep(HkJobQueue jobQueue, HkJobThreadPool threadPool) => throw new NotImplementedException();
        public void AddConstraint(HkConstraint constraint) => throw new NotImplementedException();
        public bool RemoveConstraint(HkConstraint constraint) => throw new NotImplementedException();
        public void AddRigidBody(HkRigidBody rigidBody) => throw new NotImplementedException();
        public void RemoveRigidBody(HkRigidBody rigidBody) => throw new NotImplementedException();
        public void AddRigidBodyBatch(HkRigidBody rigidBody) => throw new NotImplementedException();
        public void RemoveRigidBodyBatch(HkRigidBody rigidBody) => throw new NotImplementedException();
        public void FinishBatch() => throw new NotImplementedException();
        public void AddPhantom(HkPhantom phantom) => throw new NotImplementedException();
        public void RemovePhantom(HkPhantom phantom) => throw new NotImplementedException();
        public void AddCharacterRigidBody(HkCharacterRigidBody rigidBody) => throw new NotImplementedException();
        public void RemoveCharacterRigidBody(HkCharacterRigidBody rigidBody) => throw new NotImplementedException();
        public void AddRagdoll(HkRagdoll ragdoll) => throw new NotImplementedException();
        public void RemoveRagdoll(HkRagdoll ragdoll) => throw new NotImplementedException();
        public void GetPenetrationsShape(HkShape shape, ref Vector3 translation, ref Quaternion rotation, List<HkBodyCollision> results, int filter) => throw new NotImplementedException();
        public void GetPenetrationsShape(HkShape shape, ref Vector3 translation, ref Quaternion rotation, HashSet<HkRigidBody> results, int filter) => throw new NotImplementedException();
        public void GetPenetrationsBox(ref Vector3 halfExtents, ref Vector3 translation, ref Quaternion rotation, List<HkBodyCollision> results, int filter) => throw new NotImplementedException();
        public void GetPenetrationsShapeShape(HkShape shape1, ref Vector3 translation1, ref Quaternion rotation1, HkShape shape2, ref Vector3 translation2, ref Quaternion rotation2, List<HkShapeCollision> results) => throw new NotImplementedException();
        public bool IsPenetratingShapeShape(HkShape shape1, ref Vector3 translation1, ref Quaternion rotation1, HkShape shape2, ref Vector3 translation2, ref Quaternion rotation2) => throw new NotImplementedException();
        public bool IsPenetratingShapeShape(HkShape shape1, ref Matrix transform1, HkShape shape2, ref Matrix transform2) => throw new NotImplementedException();
        public Nullable<float> CastShape(Vector3 to, HkShape shape, Matrix transform, int filterLayer) => throw new NotImplementedException();
        public Nullable<float> CastShape(Vector3 to, HkShape shape, ref Matrix transform, int filterLayer, float extraPenetration) => throw new NotImplementedException();
        public Nullable<Vector3> CastShapeReturnPoint(Vector3 to, HkShape shape, ref Matrix transform, int filterLayer, float extraPenetration) => throw new NotImplementedException();
        public Nullable<HkContactPoint> CastShapeReturnContact(Vector3 to, HkShape shape, ref Matrix transform, int filterLayer, float extraPenetration) => throw new NotImplementedException();
        public Nullable<HkContactPointData> CastShapeReturnContactData(Vector3 to, HkShape shape, ref Matrix transform, object collisionFilterInfo, float extraPenetration) => throw new NotImplementedException();
        public Nullable<HkHitInfo> CastShapeReturnContactBodyData(Vector3 to, HkShape shape, ref Matrix transform, object collisionFilterInfo, float extraPenetration) => throw new NotImplementedException();
        public bool CastShapeReturnContactBodyDatas(Vector3 to, HkShape shape, ref Matrix transform, object collisionFilterInfo, float extraPenetration, List<Nullable<HkHitInfo>> result) => throw new NotImplementedException();
        public void CastRay(Vector3 from, Vector3 to, List<HkHitInfo> toList) => throw new NotImplementedException();
        public void CastRay(Vector3 from, Vector3 to, List<HkHitInfo> toList, int raycastFilterLayer) => throw new NotImplementedException();
        public void CastRayLockless(Vector3 from, Vector3 to, List<HkHitInfo> toList, int raycastFilterLayer) => throw new NotImplementedException();
        public Nullable<HkHitInfo> CastRay(Vector3 from, Vector3 to) => throw new NotImplementedException();
        public Nullable<HkHitInfo> CastRay(Vector3 from, Vector3 to, int rayCastFilterLayer) => throw new NotImplementedException();
        public Nullable<HkHitInfo> CastRay(Vector3 from, Vector3 to, int rayCastFilterLayer, bool useFilter) => throw new NotImplementedException();
        public bool CastRay(Vector3 from, Vector3 to, ref HkHitInfo info, object collisionFilter, bool ignoreConvexShape) => throw new NotImplementedException();
        public void MarkForWrite() => throw new NotImplementedException();
        public void UnmarkForWrite() => throw new NotImplementedException();
        public HkGroupFilter GetCollisionFilter() => throw new NotImplementedException();
        public void DisableCollisionsBetween(int layer1, int layer2) => throw new NotImplementedException();
        public void RefreshCollisionFilterOnEntity(HkEntity entity) => throw new NotImplementedException();
        public void ReintegrateCharacter(HkCharacterRigidBody character) => throw new NotImplementedException();
        public void RigidBodyActivated(HkEntity entity) => throw new NotImplementedException();
        public void ReadSimulationIslandInfos(List<HkSimulationIslandInfo> infoOut) => throw new NotImplementedException();
        public List<HkRigidBody> GetActiveRigidBodiesCache(ref int worldVersion, ref bool cacheValid) => throw new NotImplementedException();
        public void UpdateActiveRigidBodiesCache(List<HkRigidBody> activeRigidBodyCache, int cacheVersion) => throw new NotImplementedException();
        
        
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BodyCollision
        {
            public IntPtr Body;
            public uint ShapeKey;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct HitInfo
        {
            public IntPtr Body;
            public ShapePath ShapeKeys;
            public Vector3 Position;
            public Vector3 Normal;
            public float Fraction;
        }

        public enum SimulationType : byte
        {
            SIMULATION_TYPE_INVALID,
            SIMULATION_TYPE_DISCRETE,
            SIMULATION_TYPE_CONTINUOUS,
            SIMULATION_TYPE_MULTITHREADED,
        }

        public enum ContactPointGeneration : byte
        {
            CONTACT_POINT_ACCEPT_ALWAYS,
            CONTACT_POINT_REJECT_DUBIOUS,
            CONTACT_POINT_REJECT_MANY,
        }

        public enum BroadPhaseType : byte
        {
            BROADPHASE_TYPE_SAP,
            BROADPHASE_TYPE_TREE,
            BROADPHASE_TYPE_HYBRID,
        }

        public enum BroadPhaseBorderBehaviour : byte
        {
            BROADPHASE_BORDER_ASSERT,
            BROADPHASE_BORDER_FIX_ENTITY,
            BROADPHASE_BORDER_REMOVE_ENTITY,
            BROADPHASE_BORDER_DO_NOTHING,
        }
        
        
        public struct CInfo
        {
          public Vector3 Gravity;
          public int BroadPhaseQuerySize;
          public float ContactRestingVelocity;
          public HkWorld.BroadPhaseType BroadPhaseType;
          public HkWorld.BroadPhaseBorderBehaviour BroadPhaseBorderBehaviour;
          [MarshalAs(UnmanagedType.I1)]
          public bool MtPostponeAndSortBroadPhaseBorderCallbacks;
          public BoundingBox BroadPhaseWorldAabb;
          public float CollisionTolerance;
          public float ExpectedMaxLinearVelocity;
          public int SizeOfToiEventQueue;
          public float ExpectedMinPsiDeltaTime;
          public int BroadPhaseNumMarkers;
          public HkWorld.ContactPointGeneration ContactPointGeneration;
          [MarshalAs(UnmanagedType.I1)]
          public bool AllowToSkipConfirmedCallbacks;
          public float SolverTau;
          public float SolverDamp;
          public int SolverIterations;
          public int SolverMicrosteps;
          public float MaxConstraintViolation;
          [MarshalAs(UnmanagedType.I1)]
          public bool ForceCoherentConstraintOrderingInSolver;
          public float SnapCollisionToConvexEdgeThreshold;
          public float SnapCollisionToConcaveEdgeThreshold;
          [MarshalAs(UnmanagedType.I1)]
          public bool EnableToiWeldRejection;
          [MarshalAs(UnmanagedType.I1)]
          public bool EnableDeprecatedWelding;
          public float IterativeLinearCastEarlyOutDistance;
          public int IterativeLinearCastMaxIterations;
          public byte DeactivationNumInactiveFramesSelectFlag0;
          public byte DeactivationNumInactiveFramesSelectFlag1;
          public byte DeactivationIntegrateCounter;
          [MarshalAs(UnmanagedType.I1)]
          public bool ShouldActivateOnRigidBodyTransformChange;
          public float DeactivationReferenceDistance;
          public float ToiCollisionResponseRotateNormal;
          [MarshalAs(UnmanagedType.I1)]
          public bool UseCompoundSpuElf;
          public int MaxSectorsPerMidphaseCollideTask;
          public int MaxSectorsPerNarrowphaseCollideTask;
          [MarshalAs(UnmanagedType.I1)]
          public bool ProcessToisMultithreaded;
          public int MaxEntriesPerToiMidphaseCollideTask;
          public int MaxEntriesPerToiNarrowphaseCollideTask;
          public int MaxNumToiCollisionPairsSinglethreaded;
          public float NumToisTillAllowedPenetrationSimplifiedToi;
          public float NumToisTillAllowedPenetrationToi;
          public float NumToisTillAllowedPenetrationToiHigher;
          public float NumToisTillAllowedPenetrationToiForced;
          [MarshalAs(UnmanagedType.I1)]
          public bool EnableDeactivation;
          public HkWorld.SimulationType SimulationType;
          [MarshalAs(UnmanagedType.I1)]
          public bool EnableSimulationIslands;
          public uint MinDesiredIslandSize;
          [MarshalAs(UnmanagedType.I1)]
          public bool ProcessActionsInSingleThread;
          [MarshalAs(UnmanagedType.I1)]
          public bool AllowIntegrationOfIslandsWithoutConstraintsInASeparateJob;
          public float FrameMarkerPsiSnap;
          [MarshalAs(UnmanagedType.I1)]
          public bool FireCollisionCallbacks;

          public static HkWorld.CInfo Create()
          {
            return new HkWorld.CInfo()
            {
              Gravity = new Vector3(0.0f, -9.8f, 0.0f),
              BroadPhaseQuerySize = 1024 /*0x0400*/,
              MtPostponeAndSortBroadPhaseBorderCallbacks = false,
              CollisionTolerance = 0.1f,
              ExpectedMaxLinearVelocity = 200f,
              SizeOfToiEventQueue = 250,
              ExpectedMinPsiDeltaTime = 0.033333335f,
              AllowToSkipConfirmedCallbacks = false,
              SolverDamp = 0.6f,
              SolverIterations = 4,
              SolverMicrosteps = 1,
              MaxConstraintViolation = 1.8446726E+19f,
              ForceCoherentConstraintOrderingInSolver = false,
              SnapCollisionToConvexEdgeThreshold = 0.524f,
              SnapCollisionToConcaveEdgeThreshold = 0.698f,
              EnableToiWeldRejection = false,
              EnableDeprecatedWelding = false,
              IterativeLinearCastEarlyOutDistance = 0.01f,
              IterativeLinearCastMaxIterations = 20,
              DeactivationNumInactiveFramesSelectFlag0 = 0,
              DeactivationNumInactiveFramesSelectFlag1 = 0,
              DeactivationIntegrateCounter = 0,
              ShouldActivateOnRigidBodyTransformChange = true,
              DeactivationReferenceDistance = 0.02f,
              ToiCollisionResponseRotateNormal = 0.2f,
              UseCompoundSpuElf = false,
              MaxSectorsPerMidphaseCollideTask = 2,
              MaxSectorsPerNarrowphaseCollideTask = 4,
              ProcessToisMultithreaded = true,
              MaxEntriesPerToiMidphaseCollideTask = -1,
              MaxEntriesPerToiNarrowphaseCollideTask = -1,
              MaxNumToiCollisionPairsSinglethreaded = 0,
              NumToisTillAllowedPenetrationSimplifiedToi = 3f,
              NumToisTillAllowedPenetrationToi = 3f,
              NumToisTillAllowedPenetrationToiHigher = 4f,
              NumToisTillAllowedPenetrationToiForced = 20f,
              EnableDeactivation = true,
              EnableSimulationIslands = true,
              MinDesiredIslandSize = 64 /*0x40*/,
              ProcessActionsInSingleThread = true,
              AllowIntegrationOfIslandsWithoutConstraintsInASeparateJob = false,
              FrameMarkerPsiSnap = 0.0001f,
              FireCollisionCallbacks = false,
              SimulationType = HkWorld.SimulationType.SIMULATION_TYPE_CONTINUOUS,
              ContactPointGeneration = HkWorld.ContactPointGeneration.CONTACT_POINT_REJECT_MANY,
              BroadPhaseNumMarkers = 0,
              BroadPhaseType = HkWorld.BroadPhaseType.BROADPHASE_TYPE_SAP,
              BroadPhaseBorderBehaviour = HkWorld.BroadPhaseBorderBehaviour.BROADPHASE_BORDER_ASSERT,
              ContactRestingVelocity = 1f
            };
          }
        }
        
    }
}
