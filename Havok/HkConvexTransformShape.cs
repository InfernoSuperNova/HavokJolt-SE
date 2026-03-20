using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkConvexTransformShape {
        public HkShape Base;
        public Matrix Transform { get;  }
        public HkConvexShape ChildShape { get;  }
        public IntPtr NativeObject { get;  }
        public HkConvexTransformShape(HkConvexShape childShape, ref Matrix transform, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public HkConvexTransformShape(HkConvexShape childShape, ref Vector3 translation, ref Quaternion rotation, ref Vector3 scale, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkConvexTransformShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkConvexTransformShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexTransformShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexTransformShape(HkShape shape) => throw new NotImplementedException();
        public HkConvexTransformShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
