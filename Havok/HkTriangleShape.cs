using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkTriangleShape {
        public IntPtr NativeObject { get;  }
        public Vector3 Extrusion { get;  }
        public Vector3 Pt2 { get;  }
        public Vector3 Pt1 { get;  }
        public Vector3 Pt0 { get;  }
        public static explicit operator HkTriangleShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkTriangleShape(HkShape shape) => throw new NotImplementedException();
        public HkTriangleShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
