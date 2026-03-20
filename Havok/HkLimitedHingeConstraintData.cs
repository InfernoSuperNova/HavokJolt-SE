using VRageMath;

namespace Havok {
    public partial class HkLimitedHingeConstraintData {
        public HkConstraintMotor Motor { get; set;  }
        public bool MotorEnabled { get;  }
        public float TargetAngle { get; set;  }
        public float MaxFrictionTorque { get; set;  }
        public float MinAngularLimit { get; set;  }
        public float MaxAngularLimit { get; set;  }
        public Vector3 BodyAPos { get;  }
        public Vector3 BodyBPos { get;  }
        public void SetInBodySpaceInternal(ref Vector3 pivotA, ref Vector3 pivotB, ref Vector3 axisA, ref Vector3 axisB, ref Vector3 axisAPerp, ref Vector3 axisBPerp) => throw new NotImplementedException();
        public HkLimitedHingeConstraintData() { /* Initialize Jolt Equivalent Here */ }
        public void SetMotorEnabled(HkConstraint constraint, bool enabled) => throw new NotImplementedException();
        public void DisableLimits() => throw new NotImplementedException();
        public void SetCurrentAngle(float angle) => throw new NotImplementedException();
        public static float GetCurrentAngle(HkConstraint constraint) => throw new NotImplementedException();
        public static void SetCurrentAngle(HkConstraint constraint, float value) => throw new NotImplementedException();
        public HkLimitedHingeConstraintData(IntPtr data) { /* Initialize Jolt Equivalent Here */ }
    }
}
