using VRageMath;

namespace Havok {
    public partial class HkCharacterRigidBodyCinfo {
        public int CollisionFilterInfo { get; set;  }
        public HkShape Shape { get; set;  }
        public HkShape CrouchShape { get; set;  }
        public Vector3 Position { get; set;  }
        public Quaternion Rotation { get; set;  }
        public float Mass { get; set;  }
        public float JumpHeight { get; set;  }
        public float Friction { get; set;  }
        public float MaxLinearVelocity { get; set;  }
        public float AllowedPenetrationDepth { get; set;  }
        public Vector3 Up { get; set;  }
        public float MaxSlope { get; set;  }
        public float MaxForce { get; set;  }
        public float UnweldingHeightOffsetFactor { get; set;  }
        public float MaxSpeedForSimplexSolver { get; set;  }
        public float SupportDistance { get; set;  }
        public float HardSupportDistance { get; set;  }
        public HkCharacterRigidBodyCinfo() { /* Initialize Jolt Equivalent Here */ }
    }
}
