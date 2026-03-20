using VRageMath;

namespace Havok {
    public partial class HkPrismaticConstraintData {
        public float MaximumLinearLimit { get; set;  }
        public float MinimumLinearLimit { get; set;  }
        public float MaxFrictionForce { get; set;  }
        public float TargetPosition { get; set;  }
        public HkConstraintMotor Motor { get; set;  }
        public bool MotorEnabled { get;  }
        public HkPrismaticConstraintData() { /* Initialize Jolt Equivalent Here */ }
        public void SetInBodySpaceInternal(ref Vector3 bodyA, ref Vector3 bodyB, ref Vector3 axisA, ref Vector3 axisB, ref Vector3 axisAperp, ref Vector3 axisBperp) => throw new NotImplementedException();
    }
}
