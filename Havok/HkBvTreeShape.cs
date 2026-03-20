using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBvTreeShape {
        public IntPtr NativeObject { get;  }
        public HkShapeContainerIterator GetIterator(HkShapeBuffer buffer) => throw new NotImplementedException();
        public static explicit operator HkBvTreeShape(HkShape shape) => throw new NotImplementedException();
        public HkBvTreeShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
