using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkPhantomCallbackShape {
        public IntPtr NativeObject { get;  }
        public HkPhantomCallbackShape(HkPhantomHandler enterCallback, HkPhantomHandler leaveCallback) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkPhantomCallbackShape shape) => throw new NotImplementedException();
        public HkPhantomCallbackShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
