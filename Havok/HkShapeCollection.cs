using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkShapeCollection {
        public IntPtr NativeObject { get;  }
        public int ShapeCount { get;  }
        public HkShape GetShape(object shapeKey, HkShapeBuffer buffer) => throw new NotImplementedException();
        public static implicit operator HkShape(HkShapeCollection shape) => throw new NotImplementedException();
        public HkShapeCollection(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
