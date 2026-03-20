using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkUniformGridShape {
        public HkShape Base;
        public int ShapeCount { get;  }
        public IntPtr NativeObject { get;  }
        public HkUniformGridShape(HkUniformGridShapeArgs args) { /* Initialize Jolt Equivalent Here */ }
        public void DiscardLargeData() => throw new NotImplementedException();
        public int GetHitCellsInRange(Vector3 min, Vector3 max, Vector3I[] outBuffer) => throw new NotImplementedException();
        public int GetHitsAndClear() => throw new NotImplementedException();
        public int GetMissingCellsInRange(ref Vector3I min, ref Vector3I max, Vector3I[] outBuffer) => throw new NotImplementedException();
        public int InvalidateRange(ref Vector3I minChanged, ref Vector3I maxChanged, Vector3I[] outBuffer) => throw new NotImplementedException();
        public void SetChild(int x, int y, int z, HkBvCompressedMeshShape shape, HkReferencePolicy refPolicy) => throw new NotImplementedException();
        public bool GetChild(int x, int y, int z, ref HkBvCompressedMeshShape shape) => throw new NotImplementedException();
        public void SetShapeRequestHandler(RequestShapeBlockingDelegate callback) => throw new NotImplementedException();
        public static implicit operator HkShape(HkUniformGridShape shape) => throw new NotImplementedException();
        public static implicit operator HkBvTreeShape(HkUniformGridShape shape) => throw new NotImplementedException();
        public static explicit operator HkUniformGridShape(HkBvTreeShape shape) => throw new NotImplementedException();
        public static explicit operator HkUniformGridShape(HkShape shape) => throw new NotImplementedException();
        public HkUniformGridShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
        public void EnableExtendedCache() => throw new NotImplementedException();
    }
}
