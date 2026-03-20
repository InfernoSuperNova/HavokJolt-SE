
using VRageMath;

namespace Havok {
    public partial class HkEntity {
        public event HkEntityHandler Activated;
        public event HkEntityHandler Deactivated;
        public event HkContactPointEventHandler ContactPointCallback;
        public event HkContactPointEventHandler ContactSoundCallback;
        public event HkCollisionEventHandler CollisionAddedCallback;
        public event HkCollisionEventHandler CollisionRemovedCallback;
        public bool ContactPointCallbackEnabled { get; set;  }
        public bool ContactSoundCallbackEnabled { get; set;  }
        public HkCollidableQualityType Quality { get; set;  }
        public bool IsFixed { get;  }
        public bool IsFixedOrKeyframed { get;  }
        public bool InWorld { get;  }
        public bool InWorldInternal { get;  }
        public int ContactPointCallbackDelay { get; set;  }
        public int CallbackLimit { get; set;  }
        public object UserObject { get; set;  }
        public IntPtr UserData { get; set;  }
        public Quaternion Rotation { get; set;  }
        public Vector3 Position { get; set;  }
        public Vector3 LinearVelocity { get; set;  }
        public Vector3 LinearVelocityUnsafe { get; set;  }
        public Vector3 AngularVelocity { get; set;  }
        public bool IsActive { get; set;  }
        public void SetProperty(int key, float v) => throw new NotImplementedException();
        public bool HasProperty(int key) => throw new NotImplementedException();
        public HkEntity(IntPtr referenceObj) { /* Initialize Jolt Equivalent Here */ }
        public void Activate() => throw new NotImplementedException();
        public void ForceActivate() => throw new NotImplementedException();
        public void Deactivate() => throw new NotImplementedException();
        public void UpdateMotionType(HkMotionType type) => throw new NotImplementedException();
        public HkMotionType GetMotionType() => throw new NotImplementedException();
        public void GetRigidBodyMatrix(ref Matrix matrix) => throw new NotImplementedException();
        public Matrix GetRigidBodyMatrix() => throw new NotImplementedException();
        public void GetRigidBodyMatrix(ref MatrixD matrix) => throw new NotImplementedException();
        public static ref HkMotionType GetMotionType(IntPtr handle) => throw new NotImplementedException();
    }
}
