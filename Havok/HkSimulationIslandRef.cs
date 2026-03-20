using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VRageMath;

namespace Havok;

public struct HkSimulationIslandRef(IntPtr handle)
{
    private static readonly int ActiveOffset;
  private static readonly int ActiveBitOffset;
  private readonly IntPtr m_handle = handle;

  [DllImport("Havok.dll")]
  private static extern int HkSimulationIsland_GetEntityCount(IntPtr island);

  [DllImport("Havok.dll")]
  private static extern IntPtr HkSimulationIsland_GetEntity(IntPtr island, int index);

  [DllImport("Havok.dll")]
  private static extern void HkSimulationIsland_GetBounds(IntPtr island, out BoundingBox bb);

  [DllImport("Havok.dll")]
  private static extern void HkSimulationIsland_GetOffsets(
    out int activeOffset,
    out int activeBitFieldOffset);

  static HkSimulationIslandRef()
  {
    HkSimulationIslandRef.HkSimulationIsland_GetOffsets(out HkSimulationIslandRef.ActiveOffset, out HkSimulationIslandRef.ActiveBitOffset);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static unsafe bool GetActive(IntPtr handle)
  {
    return (*(int*) (handle + HkSimulationIslandRef.ActiveOffset).ToPointer() >> HkSimulationIslandRef.ActiveBitOffset & 3) == 1;
  }

  public bool IsValid => this.m_handle != IntPtr.Zero;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal IntPtr GetHandle() => this.m_handle;

  public HkSimulationIslandInfo GetInfo()
  {
    this.CheckHandle();
    return new HkSimulationIslandInfo(this);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool IsActive()
  {
    this.CheckHandle();
    return HkSimulationIslandRef.GetActive(this.m_handle);
  }

  public int GetEntityCount()
  {
    this.CheckHandle();
    return HkSimulationIslandRef.HkSimulationIsland_GetEntityCount(this.m_handle);
  }

  public HkRigidBody GetEntity(int index)
  {
    this.CheckHandle();
    IntPtr entity = HkSimulationIslandRef.HkSimulationIsland_GetEntity(this.m_handle, index);
    return entity != IntPtr.Zero ? HkRigidBody.Get(entity) : (HkRigidBody) null;
  }

  public void GetBounds(out BoundingBox bounds)
  {
    this.CheckHandle();
    HkSimulationIslandRef.HkSimulationIsland_GetBounds(this.m_handle, out bounds);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private void CheckHandle()
  {
    if (this.m_handle == IntPtr.Zero)
      throw new InvalidOperationException("Island handle is null.");
  }
}