using VRageMath;

namespace Havok {
    public partial class HkCustomWheelConstraintData {
        public bool LimitsEnabled { get; set;  }
        public float SuspensionMinLimit { get; set;  }
        public float SuspensionMaxLimit { get; set;  }
        public bool FrictionEnabled { get; set;  }
        public float MaxFrictionTorque { get; set;  }
        public HkCustomWheelConstraintData() { /* Initialize Jolt Equivalent Here */ }
        public void SetInBodySpaceInternal(ref Vector3 pivotA, ref Vector3 pivotB, ref Vector3 axleA, ref Vector3 axleB, ref Vector3 suspensionAxisB, ref Vector3 steeringAxisB) => throw new NotImplementedException();
        public void SetSuspensionStrength(float v) => throw new NotImplementedException();
        public void SetSuspensionDamping(float v) => throw new NotImplementedException();
        public void SetSteeringAngle(float v) => throw new NotImplementedException();
        public void SetAngleLimits(float min, float max) => throw new NotImplementedException();
        public void DisableLimits() => throw new NotImplementedException();
        public static float GetCurrentAngle(HkConstraint constraint) => throw new NotImplementedException();
        public static void SetCurrentAngle(HkConstraint constraint, float value) => throw new NotImplementedException();
    }
}
