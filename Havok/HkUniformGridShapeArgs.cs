using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkUniformGridShapeArgs {
        public Vector3I CellsCount;
        public float CellSize;
        public float CellOffset;
        public float CellExpand;
    }
}
