using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkShapeBatch {
        public int Count { get;  }
        public HkShapeBatch(int id) { /* Initialize Jolt Equivalent Here */ }
        public void GetInfo(int shapeIndex, ref Vector3I cell) => throw new NotImplementedException();
        public void SetResult(int shapeIndex, HkBvCompressedMeshShape shape) => throw new NotImplementedException();
    }
}
