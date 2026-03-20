using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBreakOffPointInfo {
        public HkRigidBody CollidingBody;
        public HkContactPoint ContactPoint;
        public Vector3D ContactPosition;
        public float BreakingImpulse;
        public float ContactPointDirection;
    }
}
