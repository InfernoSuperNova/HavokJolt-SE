using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkListShape {
        public HkShape Base;
        public object DisabledChildrenCount { get;  }
        public int TotalChildrenCount { get;  }
        public IntPtr NativeObject { get;  }
        public HkListShape(HkShape[] shapes, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public HkListShape(HkShape[] shapes, int count, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public HkShape GetChildByIndex(int index) => throw new NotImplementedException();
        public HkShapeContainerIterator GetIterator() => throw new NotImplementedException();
        public static implicit operator HkShape(HkListShape shape) => throw new NotImplementedException();
        public static implicit operator HkShapeCollection(HkListShape shape) => throw new NotImplementedException();
        public static explicit operator HkListShape(HkShapeCollection shape) => throw new NotImplementedException();
        public static explicit operator HkListShape(HkShape shape) => throw new NotImplementedException();
        public HkListShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
