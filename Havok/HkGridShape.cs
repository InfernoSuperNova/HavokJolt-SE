using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkGridShape {
        public HkShape Base;
        public HkRigidBody DebugRigidBody { get; set;  }
        public int ShapeCount { get;  }
        public bool DebugDraw { get; set;  }
        public float CellSize { get;  }
        public IntPtr NativeObject { get;  }
        public HkGridShape(float cellSize, HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public void GetShape(Vector3I pos, List<HkShape> resultList) => throw new NotImplementedException();
        public void GetShapeInfo(int index, ref Vector3S min, ref Vector3S max, List<HkShape> resultList) => throw new NotImplementedException();
        public int GetShapeInfoCount() => throw new NotImplementedException();
        public void GetShapeMin(object shapeKey, ref Vector3S min) => throw new NotImplementedException();
        public void GetShapesInInterval(Vector3 min, Vector3 max, List<HkShape> resultList) => throw new NotImplementedException();
        public void AddShapes(Span<HkShape> shapes, Vector3S min, Vector3S max) => throw new NotImplementedException();
        public void RemoveShapes(HashSet<Vector3I> positions) => throw new NotImplementedException();
        public void CollectCellRanges(HashSet<Vector3I> positions, List<Vector3S> min, List<Vector3S> max) => throw new NotImplementedException();
        public static implicit operator HkShape(HkGridShape shape) => throw new NotImplementedException();
        public static implicit operator HkBvTreeShape(HkGridShape shape) => throw new NotImplementedException();
        public static explicit operator HkGridShape(HkShape shape) => throw new NotImplementedException();
        public static explicit operator HkGridShape(HkBvTreeShape shape) => throw new NotImplementedException();
        public HkGridShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
        public void GetShapeBounds(object shapeKey, ref Vector3I min, ref Vector3I max) => throw new NotImplementedException();
    }
}
