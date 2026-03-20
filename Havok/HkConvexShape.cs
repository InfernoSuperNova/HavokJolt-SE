using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkConvexShape {
        public static float DefaultConvexRadius;
        public IntPtr NativeObject { get;  }
        public float ConvexRadius { get; set;  }
        public HkConvexShape(string fileName, int shapeIndex) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexShape(HkShape shape) => throw new NotImplementedException();
        public HkConvexShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
