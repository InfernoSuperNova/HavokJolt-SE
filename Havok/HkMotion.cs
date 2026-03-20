using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkMotion {
        public void SetDeactivationClass(HkSolverDeactivation v) => throw new NotImplementedException();
        public HkMotion(IntPtr motion) { /* Initialize Jolt Equivalent Here */ }
    }
}
