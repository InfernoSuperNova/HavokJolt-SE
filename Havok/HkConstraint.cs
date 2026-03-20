using VRageMath;

namespace Havok {
    public partial class HkConstraint {
        public Action OnAddedToWorldCallback;
        public Action OnRemovedFromWorldCallback;
        public event ConstraintCallback OnBreakingConstraintCallback;
        public HkConstraintPriority Priority { get; set;  }
        public bool WantRuntime { get; set;  }
        public bool InWorld { get;  }
        public HkRigidBody RigidBodyA { get;  }
        public HkRigidBody RigidBodyB { get;  }
        public bool Enabled { get; set;  }
        public bool ForceDisabled { get; set;  }
        public HkConstraintData ConstraintData { get;  }
        public object UserData { get; set;  }
        public HkConstraint(HkRigidBody entityA, HkRigidBody entityB, HkConstraintData constraintData) { /* Initialize Jolt Equivalent Here */ }
        public HkConstraint(HkRigidBody entityA, HkRigidBody entityB, HkConstraintData constraintData, HkConstraintPriority priority) { /* Initialize Jolt Equivalent Here */ }
        public void SetVirtualMassInverse(Vector4 invMassA, Vector4 invMassB) => throw new NotImplementedException();
        public void GetPivotsInWorld(ref Vector3 pivotA, ref Vector3 pivotB) => throw new NotImplementedException();
        public HkConstraint(IntPtr constraintInstance, HkConstraintData constraintData) { /* Initialize Jolt Equivalent Here */ }
        public void NotifyAddedToWorld() => throw new NotImplementedException();
        public void NotifyRemovedFromWorld() => throw new NotImplementedException();
        public static void GetAttachedConstraints(HkRigidBody rigidBody, List<HkConstraint> constraintsOut) => throw new NotImplementedException();
    }
}
