using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkShapeContainerIterator {
        public bool IsValid { get;  }
        public object CurrentShapeKey { get;  }
        public HkShape CurrentValue { get;  }
        public void Next() => throw new NotImplementedException();
        public HkShape GetShape(object key) => throw new NotImplementedException();
        public HkShapeContainerIterator(IntPtr container, HkShapeBuffer shapeBuffer) { /* Initialize Jolt Equivalent Here */ }
        public bool IsShapeKeyValid(object shapeKey) => throw new NotImplementedException();
    }
}
