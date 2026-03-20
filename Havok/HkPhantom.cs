namespace Havok;

public abstract class HkPhantom(IntPtr referenceObj, bool track = false) : HkReferenceObject(referenceObj, track)
{
}