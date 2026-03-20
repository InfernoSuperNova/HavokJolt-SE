using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBodyCollision {
        public HkRigidBody Body;
        public object ShapeKey;
    }
}
