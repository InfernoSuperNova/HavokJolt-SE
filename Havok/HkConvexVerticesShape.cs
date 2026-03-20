using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkConvexVerticesShape {
        public HkShape Base;
        public IntPtr NativeObject { get;  }
        public Vector3 Center { get;  }
        public int VertexCount { get;  }
        public int FaceCount { get;  }
        public HkConvexVerticesShape(Vector3[] verts, int count) { /* Initialize Jolt Equivalent Here */ }
        public HkConvexVerticesShape(Vector3[] verts, int count, bool shrink, float convexRadius) { /* Initialize Jolt Equivalent Here */ }
        public void GetGeometry(HkGeometry geometry, ref Vector3 center) => throw new NotImplementedException();
        public void GetVertices(ref Vector3[] vertices) => throw new NotImplementedException();
        public static implicit operator HkShape(HkConvexVerticesShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkConvexVerticesShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexVerticesShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkConvexVerticesShape(HkShape shape) => throw new NotImplementedException();
        public HkConvexVerticesShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
