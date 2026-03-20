namespace Havok;

public enum HkMotionType : byte
{
    Invalid,
    Dynamic,
    Sphere_Inertia,
    Box_Inertia,
    Keyframed,
    Fixed,
    Thin_Box_Inertia,
    Character,
}