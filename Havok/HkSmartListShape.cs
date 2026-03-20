using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkSmartListShape {
        public HkShape Base;
        public int ShapeCount { get;  }
        public IntPtr NativeObject { get;  }
        public HkSmartListShape(int dummy) { /* Initialize Jolt Equivalent Here */ }
        public void AddShape(HkShape shape) => throw new NotImplementedException();
        public static implicit operator HkShape(HkSmartListShape shape) => throw new NotImplementedException();
        public static implicit operator HkBvTreeShape(HkSmartListShape shape) => throw new NotImplementedException();
        public HkSmartListShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
