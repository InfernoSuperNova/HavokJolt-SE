using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBvShape {
        public HkShape Base;
        public HkShape ChildShape { get;  }
        public HkShape BoundingVolumeShape { get;  }
        public IntPtr NativeObject { get;  }
        public HkBvShape(HkShape boundingVolumeShape, HkShape childShape, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkBvShape shape) => throw new NotImplementedException();
        public static explicit operator HkBvShape(HkShape shape) => throw new NotImplementedException();
        public HkBvShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
