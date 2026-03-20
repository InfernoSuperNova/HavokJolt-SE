namespace Havok {
    public partial class HkConstraintData {
        public float MaximumLinearImpulse { get; set;  }
        public float MaximumAngularImpulse { get; set;  }
        public float BreachImpulse { get; set;  }
        public float InertiaStabilizationFactor { get; set;  }
        public void SetSolvingMethod(HkSolvingMethod method) => throw new NotImplementedException();
        public HkConstraintData() { /* Initialize Jolt Equivalent Here */ }
    }
}
