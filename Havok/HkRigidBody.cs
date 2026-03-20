using VRageMath;

namespace Havok {
    public partial class HkRigidBody {
        public BreakPartsHandler BreakPartsHandler;
        public BreakLogicHandler BreakLogicHandler;
        public HkResponseModifiers ResponseModifiers { get; set;  }
        public Vector3 Gravity { get; set;  }
        public bool EnableDeactivation { get; set;  }
        public HkMotion Motion { get;  }
        public float Mass { get; set;  }
        public Vector3 CenterOfMassLocal { get; set;  }
        public Matrix InertiaTensor { get; set;  }
        public Matrix InverseInertiaTensor { get; set;  }
        public Vector4 DeltaAngle { get;  }
        public Vector3 CenterOfMassWorld { get;  }
        public float LinearDamping { get; set;  }
        public float AngularDamping { get; set;  }
        public float MaxLinearVelocity { get; set;  }
        public float MaxAngularVelocity { get; set;  }
        public float AllowedPenetrationDepth { get; set;  }
        public float Friction { get; set;  }
        public float Restitution { get; set;  }
        public int Layer { get; set;  }
        public bool MarkedForVelocityRecompute { get; set;  }
        public string DebugName { get;  }
        public bool IsEnvironment { get; set;  }
        public int DeactivationCounter0 { get;  }
        public int DeactivationCounter1 { get;  }
        public HkRigidBody(HkRigidBodyCinfo rigidBodyInfo) { /* Initialize Jolt Equivalent Here */ }
        public object GetGcRoot() => throw new NotImplementedException();
        public static HkRigidBody Clone(HkRigidBody cloneBody) => throw new NotImplementedException();
        public static HkRigidBody FromShape(HkShape shape) => throw new NotImplementedException();
        public HkShape GetShape() => throw new NotImplementedException();
        public HkWorldOperationResult SetShape(HkShape shape) => throw new NotImplementedException();
        public HkWorldOperationResult UpdateShape() => throw new NotImplementedException();
        public void SetMassProperties(ref HkMassProperties properties) => throw new NotImplementedException();
        public void SetWorldMatrix(Matrix m) => throw new NotImplementedException();
        public Vector3 GetVelocityAtPoint(Vector3 worldPos) => throw new NotImplementedException();
        public void ApplyLinearImpulse(Vector3 impulse) => throw new NotImplementedException();
        public void ApplyPointImpulse(Vector3 impulse, Vector3 point) => throw new NotImplementedException();
        public void ApplyAngularImpulse(Vector3 impulse) => throw new NotImplementedException();
        public void SetCollisionFilterInfo(object info) => throw new NotImplementedException();
        public object GetCollisionFilterInfo() => throw new NotImplementedException();
        public void ApplyForce(float time, Vector3 force) => throw new NotImplementedException();
        public void ApplyForce(float time, Vector3 force, Vector3 point) => throw new NotImplementedException();
        public void RemoveFromWorld() => throw new NotImplementedException();
        public void AddGravity() => throw new NotImplementedException();
        public bool HasConstraints() => throw new NotImplementedException();
        public void SetCustomVelocity(Vector3 velocity, bool valid) => throw new NotImplementedException();
        public bool GetCustomVelocity(ref Vector3 velocity) => throw new NotImplementedException();
        public HkRigidBody(IntPtr body) { /* Initialize Jolt Equivalent Here */ }
        
        internal static HkRigidBody Get(IntPtr bodyHandle) => throw new NotImplementedException();
    }
}
