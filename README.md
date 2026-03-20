# Space Engineers Jolt Physics — Patch Progress Tracker

> **Strategy**: Harmony-patch the game's physics classes directly, replacing Keen's Havok-based
> physics logic with clean Jolt implementations. No DLL replacement, no HavokWrapper shimming.
>
> **Why this approach**: The game has only **430 methods across 95 classes** that touch HavokWrapper,
> compared to **2,517 patchable members** inside HavokWrapper itself. Patching the game side means
> fewer patches, cleaner architecture, and the freedom to fix Keen's questionable physics decisions.

---

## Phase 1: Core Physics Engine
> Get a Jolt world running. Entities exist in it. Simulation steps.

### `Sandbox.Engine.Physics.MyPhysics` — 38 methods ⬜
The global physics manager. Creates worlds, steps simulation, handles raycasts.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `InitCollisionFilters(HkWorld)` | Sets up collision layer filtering |
| ⬜ | `OnClusterCreated(Int32, BoundingBoxD)` | Creates HkWorld per cluster |
| ⬜ | `CreateHkWorld(Single)` | **KEY** — World factory method |
| ⬜ | `CreateWorldCInfo(...)` | World configuration |
| ⬜ | `HavokWorld_EntityLeftWorld(HkEntity)` | Entity out-of-bounds handler |
| ⬜ | `UpdateCharacters()` | Per-frame character physics update |
| ⬜ | `UpdateActiveRigidBodies()` | Per-frame rigid body sync |
| ⬜ | `StepWorldsSequential()` | **KEY** — Sequential world stepping |
| ⬜ | `StepWorldsMeasured(List)` | Measured/profiled stepping |
| ⬜ | `StepWorldsParallel()` | Parallel world stepping |
| ⬜ | `StepSingleWorld(HkWorld)` | **KEY** — Single world step |
| ⬜ | `IterateBodies(HkWorld)` | Iterates rigid bodies post-step |
| ⬜ | `IterateCharacters(HkWorld)` | Iterates characters post-step |
| ⬜ | `EnsureClusterSpace()` | Cluster management |
| ⬜ | `DrawIslands()` | Debug: simulation island visualization |
| ⬜ | `StepVDB()` | Debug: visual debugger stepping |
| ⬜ | `DebugDrawClusters()` | Debug: cluster visualization |
| ⬜ | `ExecuteParallelRayCasts()` | Batched raycast execution |
| ⬜ | `get_SingleWorld()` | Property: single-world accessor |
| ⬜ | `GetPenetrationsShape(HkShape, ...)` | Shape penetration query (2 overloads) |
| ⬜ | `GetPenetrationsShapeShape(...)` | Shape-vs-shape penetration (2 overloads) |
| ⬜ | `GetPenetrationsShapeParallel(...)` | Async shape penetration query |
| ⬜ | `CastShape(...)` | Shape cast query |
| ⬜ | `CastShapeInAllWorlds(...)` | Shape cast across all clusters |
| ⬜ | `CastShapeReturnPoint(...)` | Shape cast → hit point |
| ⬜ | `CastShapeReturnContact(...)` | Shape cast → contact info |
| ⬜ | `CastShapeReturnContactData(...)` | Shape cast → contact data |
| ⬜ | `CastShapeReturnContactBodyData(...)` | Shape cast → body + contact |
| ⬜ | `CastShapeReturnContactBodyDatas(...)` | Shape cast → multiple results |
| ⬜ | `IsPenetratingShapeShape(...)` | Boolean penetration test (2 overloads) |
| ⬜ | `IsPenetratingShapeShapeInsideOfHavok(...)` | Penetration test (Havok-locked) |
| ⬜ | `CastRayInternal(...)` | Internal raycast |
| ⬜ | `CastRayInternalLockless(...)` | Lock-free raycast |
| ⬜ | `CastRay(...)` | Public raycast API |
| ⬜ | `CastRayWorld(...)` | Per-cluster raycast |

### `Sandbox.Engine.Physics.MyPhysicsBody` — 54 methods ⬜
The physics component attached to every entity (grids, characters, floating objects, etc.)

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_HavokWorld()` | Returns the HkWorld this body lives in |
| ⬜ | `get_RigidBody()` / `set_RigidBody()` | **KEY** — Primary rigid body |
| ⬜ | `get_RigidBody2()` / `set_RigidBody2()` | Secondary rigid body (kinematic) |
| ⬜ | `get_WeldedRigidBody()` / `set_WeldedRigidBody()` | Welded compound body |
| ⬜ | `CreateFromCollisionObject(HkShape, ...)` | **KEY** — Creates body from shape |
| ⬜ | `CreateBody(HkShape, MassProperties)` | **KEY** — Low-level body creation |
| ⬜ | `CreateCharacterCollision(...)` | Character body creation |
| ⬜ | `GetInfoFromFlags(HkRigidBodyCinfo, RigidBodyFlag)` | Configures body from flags |
| ⬜ | `Activate(Object, UInt64)` | Adds body to world |
| ⬜ | `ActivateBatchInternal(Object)` | Batch activation |
| ⬜ | `Deactivate(Object)` | Removes body from world |
| ⬜ | `DeactivateBatchInternal(Object)` | Batch deactivation |
| ⬜ | `FinishAddBatch()` | Completes batch add |
| ⬜ | `FinishRemoveBatch(Object)` | Completes batch remove |
| ⬜ | `GetShape()` | Returns current collision shape |
| ⬜ | `SetLinearVelocity(Vector3, Boolean)` | Sets velocity (with safety check) |
| ⬜ | `set_Gravity(Vector3)` | Sets per-body gravity |
| ⬜ | `OnMotionKinematic()` | Switch to kinematic mode |
| ⬜ | `OnMotionDynamic()` | Switch to dynamic mode |
| ⬜ | `UpdateInterpolatedVelocities(HkRigidBody, Boolean)` | Velocity interpolation |
| ⬜ | `ChangeQualityType(HkCollidableQualityType)` | CCD quality setting |
| ⬜ | `UpdateMassProps()` | Recalculates mass properties |
| ⬜ | `RecreateWeldedShape(HkShape)` | Rebuilds welded compound shape |
| ⬜ | `Unweld(MyPhysicsBody, Boolean, Boolean)` | Unweld from compound |
| ⬜ | `AddConstraint(HkConstraint)` | Adds a constraint |
| ⬜ | `RemoveConstraint(HkConstraint)` | Removes a constraint |
| ⬜ | `IsConstraintValid(HkConstraint, Boolean)` | Constraint validation (2 overloads) |
| ⬜ | `UpdateConstraintsForceDisable()` | Force-disables constraints |
| ⬜ | `UpdateConstraintForceDisable(HkConstraint)` | Force-disables single constraint |
| ⬜ | `NotifyConstraintsRemovedFromWorld()` | Constraint cleanup notification |
| ⬜ | `RemoveConstraints(HkRigidBody)` | Removes all constraints on body |
| ⬜ | `OnContactPointCallback(HkContactPointEvent)` | **KEY** — Contact point handler |
| ⬜ | `OnContactSoundCallback(HkContactPointEvent)` | Contact sound handler |
| ⬜ | `OnDynamicRigidBodyActivated(HkEntity)` | Activation callback |
| ⬜ | `OnDynamicRigidBodyDeactivated(HkEntity)` | Deactivation callback |
| ⬜ | `ApplyForceWorld(...)` | Force application |
| ⬜ | `ApplyImplusesWorld(...)` | Impulse application |
| ⬜ | `AddForceTorqueBody(...)` | Force + torque application |
| ⬜ | `IsPhantomOrSubPart(HkRigidBody)` | Body type check |
| ⬜ | `DebugDraw()` | Debug visualization |
| ⬜ | `get_Ragdoll()` / `set_Ragdoll()` | Ragdoll accessor |
| ⬜ | `SwitchToRagdollMode(Boolean, Int32)` | Ragdoll activation |
| ⬜ | `OnRagdollAddedToWorld(HkRagdoll)` | Ragdoll world-add callback |
| ⬜ | `CloseRagdollMode(HkWorld)` | Ragdoll deactivation |
| ⬜ | `SetRagdollDefaults()` | Ragdoll configuration |
| ⬜ | `ApplyForceTorqueOnRagdoll(...)` | Ragdoll forces |
| ⬜ | `ApplyImpuseOnRagdoll(...)` | Ragdoll impulses |
| ⬜ | `ApplyForceOnRagdoll(...)` | Ragdoll forces (position) |
| ⬜ | `SetRagdollVelocities(List, HkRigidBody)` | Ragdoll velocity sync |

### `VRage.Game.Components.MyPhysicsComponentBase` — 4 methods ⬜
Base class in VRage.Game.dll — property accessors for RigidBody/RigidBody2.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_RigidBody()` / `set_RigidBody()` | Base class rigid body property |
| ⬜ | `get_RigidBody2()` / `set_RigidBody2()` | Base class secondary body property |

### `Sandbox.MySandboxGame` — 3 methods ⬜
Game lifecycle hooks.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `Run(Boolean, Action)` | Game main loop — initializes Havok |
| ⬜ | `Update()` | Per-frame update — steps physics |
| ⬜ | `UnloadData_UpdateThread()` | Cleanup — shuts down Havok |

---

## Phase 2: Grid Collision Shapes
> Grids have collision. You can't walk through blocks.

### `Sandbox.Game.Entities.Cube.MyGridShape` — 16 methods ⬜
Builds compound collision shapes from grid blocks.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `AddShapesFromCollector()` | Adds block shapes to compound |
| ⬜ | `MarkBreakable(HkRigidBody)` | Marks shapes as breakable |
| ⬜ | `UnmarkBreakable(HkRigidBody)` | Unmarks breakable |
| ⬜ | `MarkBreakable(HkWorld, HkRigidBody)` | World-level breakable marking |
| ⬜ | `UnmarkBreakable(HkWorld, HkRigidBody)` | World-level unmark |
| ⬜ | `RefreshBlocks(HkRigidBody, HashSet)` | Refreshes dirty block shapes |
| ⬜ | `UpdateShape(HkRigidBody, HkRigidBody)` | Updates compound shape |
| ⬜ | `UpdateMass(HkRigidBody, Boolean)` | Recalculates grid mass |
| ⬜ | `SetMass(HkRigidBody)` | Sets mass on body |
| ⬜ | `UpdateMassFromInventories(HashSet, MyPhysicsBody)` | Inventory-based mass |
| ⬜ | `CollectBlockInventories(...)` | Collects inventory masses |
| ⬜ | `SetMassProperties(MyPhysicsBody, HkMassProperties)` | Applies mass properties |
| ⬜ | `SetMassPropertiesST(MyPhysicsBody)` | Single-threaded mass set |
| ⬜ | `RecomputeSharedTensorIfNeeded()` | Shared inertia tensor |
| ⬜ | `SetSharedTensorST(HkMassProperties)` | Sets shared tensor |
| ⬜ | `op_Implicit(MyGridShape)` | Implicit cast to HkShape |

### `Sandbox.Game.Entities.Cube.MyGridPhysics` — 23 methods ⬜
Grid-specific physics: breakable bodies, deformation, contact handling.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_RigidBody()` / `set_RigidBody()` | Grid rigid body |
| ⬜ | `set_Gravity(Vector3)` | Grid gravity |
| ⬜ | `GetShape()` | Returns grid collision shape |
| ⬜ | `CreateBody(HkShape, MassProperties)` | Creates grid body |
| ⬜ | `ConvertToDynamic(Boolean, Boolean)` | Static → dynamic conversion |
| ⬜ | `ActivateCollision()` | Enables collision |
| ⬜ | `MarkBreakable(HkWorld)` | Marks grid as breakable |
| ⬜ | `UnmarkBreakable(HkWorld)` | Unmarks breakable |
| ⬜ | `BreakLogicHandler(...)` | Break-off logic callback |
| ⬜ | `BreakPartsHandler(...)` | Break-off parts callback |
| ⬜ | `BreakAtPoint(HkBreakOffPointInfo)` | Single break point |
| ⬜ | `CalculateSeparatingVelocity(...)` | Impact velocity calc (2 overloads) |
| ⬜ | `PerformDeformationOnGroup(...)` | Group deformation |
| ⬜ | `PerformDeformation(...)` | Single deformation |
| ⬜ | `RigidBody_ContactPointCallback(...)` | Contact callback |
| ⬜ | `RigidBody_ContactPointCallbackImpl(...)` | Contact callback impl |
| ⬜ | `GetGridPosition(...)` | Grid-space contact position |
| ⬜ | `RigidBody_CollisionAddedCallbackClient(...)` | Client collision added |
| ⬜ | `RigidBody_CollisionRemovedCallbackClient(...)` | Client collision removed |
| ⬜ | `PredictContactImpulse(...)` | Impulse prediction |
| ⬜ | `UpdateContactCallbackLimit()` | Callback throttling |

### `Sandbox.Game.Entities.Cube.MyCubeBlockCollector` — 6 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `Clear()` | Clears collected shapes |
| ⬜ | `AddBox(...)` | Adds box shape |
| ⬜ | `CollectBlock(...)` | Collects single block shape |
| ⬜ | `AddShapesCustom(...)` | Adds custom shapes |
| ⬜ | `AddShapesForPistonTop(...)` | Piston top shapes |
| ⬜ | `AddMass(...)` | Adds mass contribution |

### `Sandbox.Game.Entities.Cube.MyGridMassComputer` — 1 method ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `UpdateMass()` | Computes grid mass properties |

---

## Phase 3: Character Physics
> Walk around, collide with things, jetpack.

### `Sandbox.Engine.Physics.MyCharacterProxy` — 15 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_CharacterRigidBody()` / `set_CharacterRigidBody()` | Character body accessor |
| ⬜ | `CreateCharacterShape(...)` | **KEY** — Character capsule shape |
| ⬜ | `Activate(HkWorld)` | Add character to world |
| ⬜ | `Deactivate(HkWorld)` | Remove character from world |
| ⬜ | `GetState()` / `SetState(HkCharacterStateType)` | Ground/air/climbing state |
| ⬜ | `SetShapeForCrouch(HkWorld, Boolean)` | Crouch shape swap |
| ⬜ | `GetShape()` / `GetCollisionShape()` | Shape accessors |
| ⬜ | `GetRigidBody()` / `GetHitRigidBody()` | Body accessors |
| ⬜ | `RigidBody_ContactPointCallback(...)` | Character contact handler |
| ⬜ | `add/remove_ContactPointCallback(...)` | Event subscription |

### `Sandbox.Game.Entities.Character.MyCharacter` — 9 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_CharacterGroundState()` | Ground state property |
| ⬜ | `CreateAimAssistHelp()` | Aim assist physics |
| ⬜ | `RigidBody_ContactPointCallback(...)` | Character contact handler |
| ⬜ | `UpdatePredictionFlag()` | Network prediction |
| ⬜ | `UpdatePhysicalMovement()` | **KEY** — Movement physics |
| ⬜ | `ResetSupportDistanceAndFriction()` | Ground support |
| ⬜ | `UpdateCapsuleBones()` | Capsule bone sync |
| ⬜ | `OnCharacterStateChanged(...)` | State change handler |
| ⬜ | `InitDeadBodyPhysics()` | Death → ragdoll |

### `Sandbox.Game.Entities.Character.Components.MyCharacterJetpackComponent` — 2 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `MoveAndRotate(...)` | Jetpack movement |
| ⬜ | `UpdatePhysicalMovement()` | Jetpack physics update |

---

## Phase 4: Voxel Terrain Physics
> Terrain has collision. You can land on planets.

### `Sandbox.Engine.Voxels.MyVoxelPhysicsBody` — 17 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `GetRigidBody(Int32)` | Per-LOD rigid body |
| ⬜ | `GetShape(Int32, ...)` | Per-LOD shape (2 overloads) |
| ⬜ | `CreateRigidBodies()` | **KEY** — Creates voxel bodies |
| ⬜ | `CreateShapeBlocking(MyCellCoord)` | Creates mesh shape for cell |
| ⬜ | `CreateShape(VrVoxelMesh, Int32)` | Mesh → HkShape |
| ⬜ | `RequestShapeBlockingLod1(...)` | LOD1 shape request |
| ⬜ | `RequestShapeBlocking(...)` | Shape request |
| ⬜ | `RequestShapeBatchBlockingInternal(...)` | Batch shape request |
| ⬜ | `InvalidateRange(...)` | Voxel change → shape rebuild |
| ⬜ | `UpdateAfterSimulation10()` | Periodic update |
| ⬜ | `SetEmptyShapes(...)` | Empty cell optimization |
| ⬜ | `CheckAndDiscardShapes()` | Shape cleanup |
| ⬜ | `OnTaskComplete(...)` | Async shape build complete |
| ⬜ | `OnBatchTaskComplete(...)` | Batch complete |
| ⬜ | `UpdateNearbyEntities()` | LOD management |
| ⬜ | `PrefetchShapeOnRay(LineD)` | Raycast prefetch |

### `Sandbox.Engine.Voxels.MyPrecalcJobPhysicsBatch` — 2 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `DoWork()` | Background shape computation |
| ⬜ | `OnComplete()` | Completion handler |

---

## Phase 5: Mechanical Blocks & Constraints
> Rotors, pistons, connectors, landing gear, merge blocks work.

### `Sandbox.Engine.Physics.MyPhysicsExtensions` — 30 methods ⬜
Constraint setup helpers and entity lookup utilities.

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `SetInBodySpace(HkWheelConstraintData, ...)` | Wheel constraint setup |
| ⬜ | `SetInBodySpace(HkCustomWheelConstraintData, ...)` | Custom wheel setup |
| ⬜ | `SetInBodySpace(HkLimitedHingeConstraintData, ...)` | Hinge constraint setup |
| ⬜ | `SetInBodySpace(HkHingeConstraintData, ...)` | Simple hinge setup |
| ⬜ | `SetInBodySpace(HkPrismaticConstraintData, ...)` | Prismatic (piston) setup |
| ⬜ | `SetInBodySpace(HkFixedConstraintData, ...)` | Fixed constraint setup |
| ⬜ | `SetInBodySpace(HkRopeConstraintData, ...)` | Rope constraint setup |
| ⬜ | `SetInBodySpace(HkBallAndSocketConstraintData, ...)` | Ball-socket setup |
| ⬜ | `SetInBodySpace(HkCogWheelConstraintData, ...)` | Cog wheel setup |
| ⬜ | `GetBody(HkEntity)` | Entity → MyPhysicsBody |
| ⬜ | `GetEntity(HkEntity, UInt32)` | Entity lookup by shape key |
| ⬜ | `GetAllEntities(HkEntity)` | All entities on body |
| ⬜ | `GetSingleEntity(HkEntity)` | Single entity lookup |
| ⬜ | `GetOtherPhysicsBody(...)` | Other body in contact |
| ⬜ | `GetOtherEntity(...)` | Other entity in contact (4 overloads) |
| ⬜ | `GetPhysicsBody(...)` | Body from event (2 overloads) |
| ⬜ | `GetHitEntity(HkHitInfo)` | Entity from raycast hit |
| ⬜ | `GetConvexRadius(HkHitInfo)` | Convex radius from hit |
| ⬜ | `GetAllShapes(HkShape)` | Shape tree enumeration |
| ⬜ | `GetHitShape(...)` | Shape from contact event |
| ⬜ | `GetHitTriangleMaterial(...)` | Voxel material from hit |
| ⬜ | `GetShapeKeys(HkShape)` | Shape key enumeration |
| ⬜ | `GetCollisionEntity(HkBodyCollision)` | Entity from collision |
| ⬜ | `GetFlags/HasFlag/SetFlag(HkContactPointProperties, ...)` | Contact flags |

### `Sandbox.Game.Entities.Cube.MyShipConnector` — 15 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `CreatePhysicsBody(...)` | Connector body creation |
| ⬜ | `CreateDetectorShape(...)` | Proximity detector shape |
| ⬜ | `phantom_Enter/LeaveConnector(...)` | Connector detection |
| ⬜ | `phantom_Enter/LeaveEjector(...)` | Ejector detection |
| ⬜ | `UpdateBeforeSimulation10()` | Periodic connector update |
| ⬜ | `CreateConstraintNosync(...)` | Creates lock constraint |
| ⬜ | `SetConstraint(...)` | Sets active constraint |
| ⬜ | `RecreateConstraintInternal()` | Constraint recreation |
| ⬜ | `AddConstraint(HkConstraint)` | Adds constraint to world |
| ⬜ | `DetachInternal()` | Detach logic |
| ⬜ | `RemoveConstraint(...)` | Removes constraint |
| ⬜ | `CreateBodyConstraint(...)` | Fixed constraint creation |
| ⬜ | `DisposeBodyConstraint(...)` | Constraint disposal |

### `Sandbox.Game.Entities.Blocks.MyPistonBase` — 6 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `InitSubpartsPhysics()` | Piston subpart setup |
| ⬜ | `CreateSubpartsConstraint(...)` | Piston constraint |
| ⬜ | `UpdatePhysicsShape()` | Shape update on extend |
| ⬜ | `LinearDispacementOf(HkConstraint)` | Current extension |
| ⬜ | `IsImpulseOverThreshold(...)` | Safety disconnect |
| ⬜ | `GetConstraintImpulses(...)` | Impulse readback |

### `Sandbox.Game.Entities.Cube.MyMotorStator` — 4 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `UpdateBeforeSimulation()` | Rotor update |
| ⬜ | `SetConstraintPosition(...)` | Rotor pivot |
| ⬜ | `CreateConstraint(...)` | Rotor constraint |
| ⬜ | `GetConstraintPosition(...)` | Pivot query |

### `Sandbox.Game.Entities.Cube.MyMotorSuspension` — 4 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_SafeBody()` | Safe body accessor |
| ⬜ | `CubeGrid_OnPhysicsChanged(...)` | Physics change handler |
| ⬜ | `CreateConstraint(...)` | Suspension constraint |
| ⬜ | `Accelerate(Single, Boolean)` | Wheel drive force |

### `SpaceEngineers.Game.Entities.Blocks.MyLandingGear` — 5 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_SafeConstraint()` | Safe constraint accessor |
| ⬜ | `FindBodyResult(...)` | Landing target search |
| ⬜ | `FindBody(...)` | Body lookup |
| ⬜ | `CanAttachTo(...)` | Attachment validation |
| ⬜ | `Attach(...)` | Creates lock constraint |

### `SpaceEngineers.Game.Entities.Blocks.MyShipMergeBlock` — 8 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_SafeConstraint()` | Safe constraint accessor |
| ⬜ | `LoadDummies()` | Dummy setup |
| ⬜ | `CreateFieldShape(...)` | Detector shape |
| ⬜ | `phantom_Enter/Leave(...)` | Merge detection |
| ⬜ | `CreateConstraint(...)` | Merge constraint |
| ⬜ | `AddConstraint(...)` | Adds to world |
| ⬜ | `SetConstraint(...)` | Sets active constraint |

### `Sandbox.Game.Entities.Blocks.MyMechanicalConnectionBlockBase` — 3 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_Constraint()` / `set_Constraint()` | Constraint property |
| ⬜ | `get_SafeConstraint()` | Null-safe accessor |

---

## Phase 6: Gameplay Physics
> Everything else: doors, sensors, explosions, debris, placement checks, etc.

### Entities & Placement — 20 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyCubeGrid` | `TestBlockPlacementArea(...)` | Block placement validation |
| ⬜ | `MyCubeGrid` | `TestBlockPlacementAreaVanilla(...)` | Vanilla placement check |
| ⬜ | `MyCubeGrid` | `TestPlacementAreaInternal2(...)` | Internal placement (2 overloads) |
| ⬜ | `MyCubeGrid` | `TestGridPlacement(...)` | Grid placement check |
| ⬜ | `MyCubeGrid` | `TestPlacementForWheel(...)` | Wheel placement |
| ⬜ | `MyCubeGrid` | `TestPlacementForWheelWhenPlacingWheel(...)` | Wheel-on-wheel |
| ⬜ | `MyCubeGrid` | `GetCylynderColliderForWheels(...)` | Wheel collider |
| ⬜ | `MyCubeGrid` | `TestQueryIntersection(...)` | Intersection test |
| ⬜ | `MyCubeGrid` | `IntersectsWithWheel(...)` | Wheel intersection |
| ⬜ | `MyCubeGrid` | `Teleport(...)` | Grid teleport |
| ⬜ | `MyEntities` | `IsShapePenetrating(...)` | Penetration check (2 overloads) |
| ⬜ | `MyEntities` | `FindFreePlace(...)` | Free space search |
| ⬜ | `MyEntities` | `FindFreePlaceCustom(...)` | Custom free space |
| ⬜ | `MyEntities` | `TestPlaceInSpace(...)` | Space test (2 overloads) |
| ⬜ | `MyEntities` | `TestPlaceInSpaceInternal(...)` | Internal space test |
| ⬜ | `MyEntities` | `FindFreePlaceVoxelMap(...)` | Voxel free space |
| ⬜ | `MyEntities` | `DebugDraw()` | Entity debug draw |
| ⬜ | `MyCubeBuilder` | `AutogenerateMountpoints(...)` | Mount point generation (2 overloads) |
| ⬜ | `MyCubeBuilder` | `FindMountPoint(...)` | Mount point detection |
| ⬜ | `MyCubeBuilder` | `GetFreeSpacePlacementPosition(...)` | Placement position |

### Doors & Subparts — 7 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyDoorBase` | `CreateSubpartConstraint(...)` | Door constraint |
| ⬜ | `MyDoorBase` | `ContactCallback(...)` | Door contact |
| ⬜ | `MyDoorBase` | `DisposeSubpartConstraint(...)` | Constraint cleanup |
| ⬜ | `MyDoor` | `CreateConstraint(...)` | Simple door constraint |
| ⬜ | `MyAdvancedDoor` | `InitSubparts()` | Advanced door setup |
| ⬜ | `MyAirtightDoorGeneric` | `CreateConstraints()` | Airtight door constraints |
| ⬜ | `MyAirtightDoorGeneric` | `DisposeConstraints()` | Constraint cleanup |

### Safe Zones — 8 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MySafeZone` | `RecreatePhysics(...)` | Safe zone physics |
| ⬜ | `MySafeZone` | `ShouldDoPhysicalOverlap(...)` | Overlap check |
| ⬜ | `MySafeZone` | `CreateFieldShape()` | Zone shape |
| ⬜ | `MySafeZone` | `GetHkShape()` | Shape accessor |
| ⬜ | `MySafeZone` | `phantom_Enter/Leave(...)` | Zone enter/leave |
| ⬜ | `MySafeZone` | `OnGridSplit(...)` | Grid split handler |
| ⬜ | `MySafeZone` | `RemoveEntityPhantom(...)` | Phantom removal |

### Gravity Generators — 8 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyGravityGeneratorBase` | `Init(...)` | Gravity gen init |
| ⬜ | `MyGravityGeneratorBase` | `GetHkShape()` | Shape accessor |
| ⬜ | `MyGravityGeneratorBase` | `UpdateFieldShape()` | Field shape update |
| ⬜ | `MyGravityGeneratorBase` | `CreateFieldShape()` | Field shape creation |
| ⬜ | `MyGravityGeneratorBase` | `phantom_Enter/Leave(...)` | Field detection |
| ⬜ | `MyGravityGenerator` | `GetHkShape()` | Box shape |
| ⬜ | `MyGravityGeneratorSphere` | `GetHkShape()` | Sphere shape |

### Floating Objects, Debris, Explosions — 16 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyFloatingObject` | `RigidBody_ContactPointCallback(...)` | Contact handler |
| ⬜ | `MyFloatingObject` | `InitInternal()` | Physics init |
| ⬜ | `MyFloatingObject` | `GetPhysicsShape(...)` | Shape creation |
| ⬜ | `MyFloatingObject` | `UpdateAfterSimulationParallel()` | Parallel update |
| ⬜ | `MyDebris` | `GetDebrisShape(...)` | Debris shape |
| ⬜ | `MyDebris` | `CreateShape(...)` | Shape factory |
| ⬜ | `MyDebris` | `UnloadData()` | Cleanup |
| ⬜ | `MyDebrisBase+Physics` | `CreatePhysicsShape(...)` | Debris body |
| ⬜ | `MyDebrisBase+Physics` | `ScalePhysicsShape(...)` | Debris scaling |
| ⬜ | `MyDebrisTree+Physics` | `CreatePhysicsShape(...)` | Tree debris |
| ⬜ | `MyDebrisVoxel+Physics` | `CreatePhysicsShape(...)` | Voxel debris |
| ⬜ | `MyDebrisVoxel+Physics` | `ScalePhysicsShape(...)` | Voxel debris scaling |
| ⬜ | `MyExplosion` | `ApplyVolumetricExplosionOnEntities(...)` | Explosion damage |
| ⬜ | `MyExplosion` | `ProcessVolumetricExplosion(...)` | Explosion processing |
| ⬜ | `MyMeteor` | `InitInternal()` / `GetPhysicsShape(...)` | Meteor physics |
| ⬜ | `MyMeteor` | `RigidBody_ContactPointCallback(...)` | Meteor impact |

### Weapons, Sensors, Misc — ~20 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyCollector` | `LoadDummies()` / `CreateFieldShape(...)` | Collector setup |
| ⬜ | `MyCollector` | `phantom_Enter/Leave(...)` | Collection detection |
| ⬜ | `MyCollector` | `RigidBody_ContactPointCallback(...)` | Contact handler |
| ⬜ | `MyCollector` | `CreatePhantomConstraint()` | Phantom constraint |
| ⬜ | `MySensorBlock` | `GetHkShape()` / `UpdateAfterSimulation10()` | Sensor physics |
| ⬜ | `MyWheel` | `IsAcceptableContact(...)` | Wheel contact filter |
| ⬜ | `MyWheel` | `CollisionAdded/Removed(...)` | Wheel collision events |
| ⬜ | `MyWheel` | `ContactPointCallback(...)` | Wheel contact |
| ⬜ | `MyRealWheel` | `ContactPointCallback(...)` | Real wheel contact |
| ⬜ | `MySpaceBall` | `RefreshPhysicsBody()` / `ContactPointCallback(...)` | Space ball |
| ⬜ | `MyVirtualMass` | `Init(...)` | Virtual mass |
| ⬜ | `MyTargetDummyBlock` | `InitializeSubpart(...)` | Target dummy |
| ⬜ | `MyAmmoBase` | `OnContactPointCallback(...)` | Ammo impact |
| ⬜ | `MyDrillSensorRayCast` | `ProcessToolRaycast()` | Drill raycast |
| ⬜ | `MyThrust` | `ThrustDamageShapeCast(...)` | Thruster damage cast |
| ⬜ | `MyThrust` | `ThrustDamageDealDamage(...)` | Thruster damage apply |
| ⬜ | `MyThrust` | `DamageGrid(...)` | Thruster grid damage |
| ⬜ | `MyHandToolBase` | `InitBlockingPhysics(...)` | Hand tool physics |

---

## Phase 7: Ragdoll & Debug (Low Priority)

### `Sandbox.Engine.Physics.MyRagdollMapper` — 8 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `get_Ragdoll()` | Ragdoll accessor |
| ⬜ | `SetBoneTo(...)` | Bone positioning |
| ⬜ | `RecalculateTransformsUpwardRecursive(...)` | Bone chain recalc |
| ⬜ | `GetCharacterBoneIndex(...)` | Bone index lookup |
| ⬜ | `OnRagdollAdded(...)` | Ragdoll world-add |
| ⬜ | `DrawShape(...)` | Debug shape draw |
| ⬜ | `SetLimitedVelocities()` | Velocity clamping |
| ⬜ | `GetBodyBindedToBone(...)` | Bone → body lookup |

### `Sandbox.Engine.Physics.MyPhysicsDebugDraw` — 3 methods ⬜

| Status | Method | Notes |
|--------|--------|-------|
| ⬜ | `GetShapeColor(...)` | Debug color by shape type |
| ⬜ | `DrawCollisionShape(...)` | Shape visualization |
| ⬜ | `DrawGeometry(...)` | Geometry visualization |

### Misc Low Priority — ~15 methods ⬜

| Status | Class | Method | Notes |
|--------|-------|--------|-------|
| ⬜ | `MyPhysicsHelper` | `InitSpherePhysics(...)` | Helper: sphere body |
| ⬜ | `MyPhysicsHelper` | `InitBoxPhysics(...)` | Helper: box body (2 overloads) |
| ⬜ | `MyPhysicsHelper` | `InitCapsulePhysics(...)` | Helper: capsule body |
| ⬜ | `MyPhysicsHelper` | `InitModelPhysics(...)` | Helper: model body |
| ⬜ | `MyPhysicsBody+MyWeldInfo` | `UpdateMassProps(...)` | Weld mass update |
| ⬜ | `MyPhysicsBody+MyWeldInfo` | `SetMassProps(...)` | Weld mass set |
| ⬜ | `MyCharacterRagdollComponent` | `UpdateBeforeSimulation()` | Ragdoll update |
| ⬜ | `MyCharacterRagdollComponent` | `UpdateSimulate()` | Ragdoll simulate |
| ⬜ | `MyCharacterDetectorComponent` | `get/set_HitBody()` | Hit body property |
| ⬜ | `MyCharacterClosestDetectorComponent` | `DoDetection(...)` | Closest detection |
| ⬜ | `MyCharacterShapecastDetectorComponent` | `DoDetection(...)` | Shapecast detection |
| ⬜ | `MyThirdPersonSpectator` | `RaycastOccludingObjects(...)` | Camera collision |
| ⬜ | `MyThirdPersonSpectator` | `IsEntityFiltered(...)` | Camera filter |
| ⬜ | `ModAPIMass` | `FromHkMass(...)` | Mass conversion |
| ⬜ | `MyModel` | `LoadData(...)` | Model physics data |
| ⬜ | `MySnapshot` | `ApplyPhysics(...)` | Replication snapshot |
| ⬜ | `MyEnvironmentSector` | `BuildShape()` / `PreparePhysicsBody()` | Environment physics |
| ⬜ | `MyBreakableEnvironmentProxy` | `SectorOnContactPoint(...)` | Breakable environment |
| ⬜ | `MyExternalPathfinding` | `DrawGeometry(...)` / `DebugDrawShape(...)` | Pathfinding debug |
| ⬜ | `MyNavigationInputMesh` | `ParsePhysicalShape(...)` / `AddPhysicalShapes(...)` | Nav mesh |
| ⬜ | `MyShipSoundComponent` | `RigidBody_ContactPointCallback(...)` | Sound on contact |
| ⬜ | `MyAudioComponent` | `ShouldPlayContactSound(...)` | Contact sound check |
| ⬜ | `MyGuiScreenDebugTiming` | `Update(...)` | Debug timing display |
| ⬜ | `PhysicsStepOptimizerBase` | `ForEveryActivePhysicsBodyOfType(...)` | Optimizer iteration |
| ⬜ | `DisableGridTOIsOptimizer` | `<EnableOptimizations>b__4_0(...)` | TOI optimizer |
| ⬜ | `MyGridPhysicalGroupData` | `GetGroupSharedProperties(...)` | Group properties |
| ⬜ | `MyGridPhysicalGroupData` | `GetSharedPxProperties(...)` | Shared physics props |
| ⬜ | `MyGridContactInfo` | `get/set_Flags()` / `HandleEvents()` | Contact info |
| ⬜ | `MyInventoryBagEntity` | `Init(...)` / `OnPhysicsContactPointCallback(...)` | Inventory bag |
| ⬜ | `MyCargoContainerInventoryBagEntity` | `CreatePhysics()` / `GetPhysicsShape(...)` | Cargo bag |
| ⬜ | `MyForageableEntity` | `Init(...)` | Forageable entity |
| ⬜ | `MyUseObjectsComponent` | `RecreatePhysics()` | Use object physics |
| ⬜ | `MyParallelEntityUpdateOrchestrator` | `PerformParallelUpdate(...)` | Parallel orchestrator |
| ⬜ | `MySpiderLogic` | `IsPositionObstructed(...)` | Spider AI |
| ⬜ | `MyTreeAvoidance` | `AccumulateCorrection(...)` | Tree avoidance AI |
| ⬜ | `MyDebrisBase+Logic` | `Init(...)` | Debris init |
| ⬜ | `MyDebrisTree` | `UpdateBeforeSimulation()` | Tree debris update |
| ⬜ | `ModAPI.MyPhysics` | `CreateMassCombined(...)` | ModAPI mass |
| ⬜ | `ModAPI.MyPhysics` | `CreateModelPhysics(...)` | ModAPI model physics |
| ⬜ | `ModAPI.MyPhysics` | `CreatePhysics(...)` | ModAPI physics creation |

---

## Summary

| Phase | Description | Classes | Methods | Status |
|-------|-------------|---------|---------|--------|
| 1 | Core Physics Engine | 4 | ~99 | ⬜ Not Started |
| 2 | Grid Collision Shapes | 4 | ~46 | ⬜ Not Started |
| 3 | Character Physics | 3 | ~26 | ⬜ Not Started |
| 4 | Voxel Terrain Physics | 2 | ~19 | ⬜ Not Started |
| 5 | Mechanical Blocks & Constraints | 8 | ~75 | ⬜ Not Started |
| 6 | Gameplay Physics | ~30 | ~79 | ⬜ Not Started |
| 7 | Ragdoll, Debug & Misc | ~20 | ~86 | ⬜ Not Started |
| **Total** | | **~71** | **~430** | |

---

## Notes

- Method counts are based on analysis of game version at time of writing
- Run `tools/analyze_havok_usage.cs` after game updates to regenerate this data
- Status legend: ⬜ Not Started | 🔨 In Progress | ✅ Done | ❌ Won't Implement | ⏭️ Skipped (not needed for Jolt)
