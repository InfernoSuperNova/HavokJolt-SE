using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkShape {
        public IntPtr NativeObject { get;  }
        public HkShape Base => this;
        public static HkShape Empty { get;  }
        public bool IsZero { get;  }
        public bool IsValid { get;  }
        public int ReferenceCount { get;  }
        public HkShapeType ShapeType { get;  }
        public bool IsConvex { get;  }
        public float ConvexRadius { get; set;  }
        public object UserData { get;  }
        public string DebugName { get;  }
        public static IEqualityComparer<HkShape> Comparer { get;  }
        public void AddReference() => throw new NotImplementedException();
        public void RemoveReference() => throw new NotImplementedException();
        public HkShape(IntPtr shape) { /* Initialize Jolt Equivalent Here */ }
        public static void SetUserData(HkShape shape, object userData) => throw new NotImplementedException();
        public static void SetUserData(HkShape shape, HkRigidBody body) => throw new NotImplementedException();
        public bool IsContainer() => throw new NotImplementedException();
        public void GetLocalAABB(float tolerance, ref Vector4 min, ref Vector4 max) => throw new NotImplementedException();
        public HkShapeContainerIterator GetContainer() => throw new NotImplementedException();
        public static void FlagShapeAsReadOnly(HkShape shape) => throw new NotImplementedException();
    }
}
