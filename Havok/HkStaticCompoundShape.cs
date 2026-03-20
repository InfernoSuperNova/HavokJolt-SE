using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkStaticCompoundShape {
        public int InstanceCount { get;  }
        public IntPtr NativeObject { get;  }
        public HkStaticCompoundShape(HkReferencePolicy policy) { /* Initialize Jolt Equivalent Here */ }
        public int AddInstance(HkShape shape, Matrix transform) => throw new NotImplementedException();
        public void Bake() => throw new NotImplementedException();
        public void DecomposeShapeKey(object shapeKey, ref int instanceId, ref object childKey) => throw new NotImplementedException();
        public void EnableInstance(int instanceId, bool enable) => throw new NotImplementedException();
        public HkShape GetInstance(int instanceIndex) => throw new NotImplementedException();
        public Matrix GetInstanceTransform(int instanceIndex) => throw new NotImplementedException();
        public HkShapeContainerIterator GetIterator() => throw new NotImplementedException();
        public bool IsInstanceEnabled(int instanceId) => throw new NotImplementedException();
        public bool IsShapeKeyEnabled(object key) => throw new NotImplementedException();
        public static implicit operator HkShape(HkStaticCompoundShape shape) => throw new NotImplementedException();
        public static explicit operator HkStaticCompoundShape(HkShape shape) => throw new NotImplementedException();
        public HkStaticCompoundShape(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
