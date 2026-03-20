using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkMassElement {
        public HkMassProperties Properties;
        public Matrix Tranform;
        public HkMassElement(ref HkMassProperties properties, ref Matrix transform) { /* Initialize Jolt Equivalent Here */ }
    }
}
