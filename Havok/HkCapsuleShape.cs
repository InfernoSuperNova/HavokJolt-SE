using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkCapsuleShape {
        public HkShape Base;
        public float Radius { get;  }
        public Vector3 VertexB { get;  }
        public Vector3 VertexA { get;  }
        public IntPtr NativeObject { get;  }
        public HkCapsuleShape(Vector3 vertexA, Vector3 vertexB, float radius) { /* Initialize Jolt Equivalent Here */ }
        public static implicit operator HkShape(HkCapsuleShape shape) => throw new NotImplementedException();
        public static implicit operator HkConvexShape(HkCapsuleShape shape) => throw new NotImplementedException();
        public static explicit operator HkCapsuleShape(HkConvexShape shape) => throw new NotImplementedException();
        public static explicit operator HkCapsuleShape(HkShape shape) => throw new NotImplementedException();
        public HkCapsuleShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
