using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkContactPointEvent {
        public HkCollisionEvent Base;
        public HkContactPoint ContactPoint;
        public HkContactPointProperties ContactProperties;
        public IntPtr NativeObject { get;  }
        public bool IsToi { get;  }
        public float SeparatingVelocity { get; set;  }
        public float RotateNormal { get; set;  }
        public Type EventType { get;  }
        public bool FiringCallbacksForFullManifold { get;  }
        public bool FirstCallbackForFullManifold { get;  }
        public bool LastCallbackForFullManifold { get;  }
        public object ContactPointId { get;  }
        public void AccessVelocities(int bodyIndex) => throw new NotImplementedException();
        public void UpdateVelocities(int bodyIndex) => throw new NotImplementedException();
        public object GetShapeKey(int bodyIdx) => throw new NotImplementedException();
        public object GetShapeKey(int bodyIdx, int shapeIdx) => throw new NotImplementedException();
        public HkContactPointEvent(IntPtr inHandle) { /* Initialize Jolt Equivalent Here */ }
    }
}
