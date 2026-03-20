namespace Havok;

public enum HkCollidableQualityType
{
    Invalid = -1, // 0xFFFFFFFF
    Fixed = 0,
    Keyframed = 1,
    Debris = 2,
    DebrisSimpleToi = 3,
    Moving = 4,
    Critical = 5,
    Bullet = 6,
    User = 7,
    Character = 8,
    KeyframedReporting = 9,
}
