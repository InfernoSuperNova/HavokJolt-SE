namespace Havok;

public enum HkResponseModifiers
{
    MassScaling = 1,
    CenterOfMassDisplacement = 2,
    SurfaceVelocity = 4,
    AdditionalSizeModifiers = 7,
    ImpulseScaling = 8,
    ViscousSurface = 16, // 0x00000010
}