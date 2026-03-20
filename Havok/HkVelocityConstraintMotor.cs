namespace Havok {
    public partial class HkVelocityConstraintMotor {
        public float Tau { get; set;  }
        public float VelocityTarget { get; set;  }
        public bool ConstantRecoveryVelocity { get; set;  }
        public HkVelocityConstraintMotor(float velocityTarget, float maxForce) { /* Initialize Jolt Equivalent Here */ }
    }
}
