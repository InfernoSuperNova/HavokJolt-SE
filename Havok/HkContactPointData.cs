using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkContactPointData {
        public Vector3D HitPosition;
    }
}
