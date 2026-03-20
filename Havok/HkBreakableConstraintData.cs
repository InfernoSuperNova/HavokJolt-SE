namespace Havok {
    public partial class HkBreakableConstraintData {
        public float Threshold { get; set;  }
        public bool RemoveFromWorldOnBrake { get; set;  }
        public bool ReapplyVelocityOnBreak { get; set;  }
        public HkBreakableConstraintData(HkConstraintData data) { /* Initialize Jolt Equivalent Here */ }
        public bool getIsBroken(HkConstraint constraint) => throw new NotImplementedException();
    }
}
