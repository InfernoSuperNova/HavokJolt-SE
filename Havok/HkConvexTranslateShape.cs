using System.Runtime.InteropServices;
using VRageMath;
namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkConvexTranslateShape {
        public HkShape Base;
        public Vector3 Translation { get;  }
        public HkConvexShape ChildShape { get;  }
        public IntPtr NativeObject { get;  }
        public HkConvexTranslateShape(HkConvexShape childShape, Vector3 translation, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkConvexTranslateShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkConvexTranslateShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexTranslateShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexTranslateShape(HkShape shape) => throw new NotImplementedException();
        public HkConvexTranslateShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
