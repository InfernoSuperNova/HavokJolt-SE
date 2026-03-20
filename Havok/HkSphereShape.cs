using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkSphereShape {
        public HkShape Base;
        public float Radius { get; set;  }
        public IntPtr NativeObject { get;  }
        public HkSphereShape(float radius) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkSphereShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkSphereShape shape) => throw new NotImplementedException();
        public static explicit operator HkSphereShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkSphereShape(HkShape shape) => throw new NotImplementedException();
        public HkSphereShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
