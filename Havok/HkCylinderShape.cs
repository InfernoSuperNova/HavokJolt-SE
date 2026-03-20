using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkCylinderShape {
        public HkShape Base;
        public float Radius { get; set;  }
        public Vector3 VertexB { get; set;  }
        public Vector3 VertexA { get; set;  }
        public IntPtr NativeObject { get;  }
        public HkCylinderShape(Vector3 vertexA, Vector3 vertexB, float cylinderRadius) { /* Initialize Jolt Equivalent Here */ }
        public HkCylinderShape(Vector3 vertexA, Vector3 vertexB, float cylinderRadius, float convexRadius) { /* Initialize Jolt Equivalent Here */ }
        public static void SetNumberOfVirtualSideSegments(int number) => throw new NotImplementedException();
        public static implicit operator HkShape(HkCylinderShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkCylinderShape shape) => throw new NotImplementedException();
        public static explicit operator HkCylinderShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkCylinderShape(HkShape shape) => throw new NotImplementedException();
        public HkCylinderShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
