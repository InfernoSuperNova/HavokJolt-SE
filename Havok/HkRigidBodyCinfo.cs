using VRageMath;

namespace Havok {
    public partial class HkRigidBodyCinfo {
        public HkResponseType CollisionResponse { get; set;  }
        public HkResponseModifiers ResponseModifiers { get; set;  }
        public Vector3 Position { get; set;  }
        public Quaternion Rotation { get; set;  }
        public Vector3 LinearVelocity { get; set;  }
        public Vector3 AngularVelocity { get; set;  }
        public Vector3 CenterOfMass { get; set;  }
        public float Mass { get; set;  }
        public float LinearDamping { get; set;  }
        public float AngularDamping { get; set;  }
        public float Friction { get; set;  }
        public float Restitution { get; set;  }
        public float MaxLinearVelocity { get; set;  }
        public float MaxAngularVelocity { get; set;  }
        public object ContactPointCallbackDelay { get; set;  }
        public float AllowedPenetrationDepth { get; set;  }
        public HkMotionType MotionType { get; set;  }
        public HkSolverDeactivation SolverDeactivation { get; set;  }
        public HkCollidableQualityType QualityType { get; set;  }
        public object AutoRemoveLevel { get; set;  }
        public HkShape Shape { get; set;  }
        public HkRigidBodyCinfo() { /* Initialize Jolt Equivalent Here */ }
        public void SetMassProperties(HkMassProperties properties) => throw new NotImplementedException();
        public HkRigidBodyCinfo(IntPtr info) { /* Initialize Jolt Equivalent Here */ }
    }
}
