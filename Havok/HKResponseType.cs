namespace Havok;

public enum HkResponseType
{
    Invalid,
    SimpleContact,
    [Obsolete("Deprecated. Instead of using this, you can disable contacts from a hkpContactListener.")] Reporting,
    None,
    MaxId,
}