using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBreakOffPoints {
        public HkBreakOffPointInfo Item { get;  }
        public int Count { get;  }
        public HkBreakOffPoints(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
