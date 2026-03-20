using VRageMath;

namespace Havok {
    public partial class HkCharacterProxyCinfo {
        public Vector3 Forward;
        public Vector3 Position { get; set;  }
        public Vector3 Velocity { get; set;  }
        public float DynamicFriction { get; set;  }
        public float StaticFriction { get; set;  }
        public float KeepContactTolerance { get; set;  }
        public Vector3 Up { get; set;  }
        public float ExtraUpStaticFriction { get; set;  }
        public float ExtraDownStaticFriction { get; set;  }
        public HkpShapePhantom ShapePhantom { get; set;  }
        public float KeepDistance { get; set;  }
        public float ContactAngleSensitivity { get; set;  }
        public int UserPlanes { get; set;  }
        public float MaxCharacterSpeedForSolver { get; set;  }
        public float CharacterStrength { get; set;  }
        public float CharacterMass { get; set;  }
        public float MaxSlope { get; set;  }
        public float PenetrationRecoverySpeed { get; set;  }
        public int MaxCastIterations { get; set;  }
        public bool RefreshManifoldInCheckSupport { get; set;  }
        public HkCharacterProxyCinfo() { /* Initialize Jolt Equivalent Here */ }
    }
}
