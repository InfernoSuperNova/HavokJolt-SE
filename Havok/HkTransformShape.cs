using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkTransformShape {
        public IntPtr NativeObject { get;  }
        public Matrix Transform { get;  }
        public HkShape ChildShape { get;  }
        public HkTransformShape(HkShape childShape, ref Matrix transform) { /* Initialize Jolt Equivalent Here */ }
        public HkTransformShape(HkShape childShape, ref Vector3 translation, ref Quaternion rotation) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkTransformShape shape) => throw new NotImplementedException();
        public static explicit operator HkTransformShape(HkShape shape) => throw new NotImplementedException();
        public HkTransformShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
