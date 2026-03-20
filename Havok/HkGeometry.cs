using VRageMath;

namespace Havok {
    public partial class HkGeometry {
        public int TriangleCount { get;  }
        public int VertexCount { get;  }
        public HkGeometry() { /* Initialize Jolt Equivalent Here */ }
        public HkGeometry(IntPtr handle) { /* Initialize Jolt Equivalent Here */ }
        public HkGeometry(List<Vector3> vertices, List<int> indices, List<int> materialIndices) { /* Initialize Jolt Equivalent Here */ }
        public void GetTriangle(int triangleIndex, ref int i0, ref int i1, ref int i2, ref int materialIndex) => throw new NotImplementedException();
        public Vector3 GetVertex(int vertexIndex) => throw new NotImplementedException();
    }
}
