using VRageMath;

namespace Havok;

public class HkpShapePhantom : HkPhantom
{
    public void SetTransform(Matrix matrix) => throw new NotImplementedException();

    internal HkpShapePhantom(IntPtr ptr) : base(ptr)
    {
    }
}