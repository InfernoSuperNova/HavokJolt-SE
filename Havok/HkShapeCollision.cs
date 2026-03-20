using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkShapeCollision {
        public object ShapeKeyCount;
        public object GetShapeKey(int index) => throw new NotImplementedException();
    }
}
