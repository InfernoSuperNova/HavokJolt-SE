using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBoxShape {
        public HkShape Base;
        public Vector3 HalfExtents { get; set;  }
        public IntPtr NativeObject { get;  }
        public HkBoxShape(Vector3 halfExtents) { /* Initialize Jolt Equivalent Here */ }
        public HkBoxShape(Vector3 halfExtents, float convexRadius) { /* Initialize Jolt Equivalent Here */ }
        public HkBoxShape(string fileName, int shapeIndex) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkBoxShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkBoxShape shape) => throw new NotImplementedException();
        public static explicit operator HkBoxShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkBoxShape(HkShape shape) => throw new NotImplementedException();
        public HkBoxShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
