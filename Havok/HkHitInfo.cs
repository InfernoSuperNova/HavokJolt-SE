using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkHitInfo {
        public float HitFraction;
        public Vector3 Position;
        public Vector3 Normal;
        public HkRigidBody Body;
        public int ShapeKeyCount { get;  }
        public object GetShapeKey(int index) => throw new NotImplementedException();
        internal HkHitInfo(ref HkWorld.HitInfo hit) { /* Initialize Jolt Equivalent Here */ }
        internal HkHitInfo(float InFraction, Vector3 InPosition, Vector3 InNormal, IntPtr InBody, ShapePath shapeKeys) { /* Initialize Jolt Equivalent Here */ }
    }
}
