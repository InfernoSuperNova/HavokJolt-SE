namespace Havok;

public struct ShapePath
{
    private unsafe fixed uint m_shapeKeys[8];
    private int m_shapeKeyCount;

    public int Count => this.m_shapeKeyCount;

    public unsafe uint GetShapeKey(int index) => this.m_shapeKeys[index];

    public unsafe uint this[int index] => this.m_shapeKeys[index];
}