using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkBvCompressedMeshShape {
        public HkShape Base;
        public bool IsZero { get;  }
        public IntPtr NativeObject { get;  }
        public HkBvCompressedMeshShape(HkSimpleMeshShape simpleMesh) { /* Initialize Jolt Equivalent Here */ }
        public HkBvCompressedMeshShape(HkGeometry geometry, Span<HkConvexShape> shapes, Span<Matrix> transforms, PerPrimitiveDataMode materialDataMode, HkWeldingType weldingType) { /* Initialize Jolt Equivalent Here */ }
        public HkBvCompressedMeshShape(HkGeometry geometry, Span<HkConvexShape> shapes, Span<Matrix> transforms, HkWeldingType weldingType, PerPrimitiveDataMode materialDataMode, Nullable<float> convexRadius) { /* Initialize Jolt Equivalent Here */ }

        public unsafe HkBvCompressedMeshShape(Vector3* vertices, int verticesCount, int* indices, int indicesCount, byte* materials, int materialsCount, HkWeldingType weldingType, float convexRadius) { /* Initialize Jolt Equivalent Here */ }
        public void GetGeometry(HkGeometry result) => throw new NotImplementedException();
        public static implicit operator HkShape(HkBvCompressedMeshShape shape) => throw new NotImplementedException();
        public static explicit operator HkBvCompressedMeshShape(HkShape shape) => throw new NotImplementedException();
        public HkBvCompressedMeshShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
        
        public enum PerPrimitiveDataMode
        {
            PER_PRIMITIVE_DATA_NONE,
            PER_PRIMITIVE_DATA_8_BIT,
            PER_PRIMITIVE_DATA_PALETTE,
            PER_PRIMITIVE_DATA_STRING_PALETTE,
        }
    }
}
