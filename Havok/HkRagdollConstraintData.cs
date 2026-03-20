namespace Havok {
    public partial class HkRagdollConstraintData {
        public float PlaneMinAngularLimit { get; set;  }
        public float PlaneMaxAngularLimit { get; set;  }
        public float TwistMinAngularLimit { get; set;  }
        public float TwistMaxAngularLimit { get; set;  }
        public float MaxFrictionTorque { get; set;  }
        public HkRagdollConstraintData(IntPtr data) { /* Initialize Jolt Equivalent Here */ }
    }
}
