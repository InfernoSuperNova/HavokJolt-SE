using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkMoppBvTreeShape {
        public IntPtr NativeObject { get;  }
        public HkShapeCollection ShapeCollection { get;  }
        public HkMoppBvTreeShape(HkShapeCollection shapeCollection, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public static explicit operator HkMoppBvTreeShape(HkShape shape) => throw new NotImplementedException();
        public HkMoppBvTreeShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
