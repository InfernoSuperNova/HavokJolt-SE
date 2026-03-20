using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkSimulationIslandInfo {
        
        
        private HkSimulationIslandRef m_handle;
        
        
        public BoundingBox AABB;
        public bool IsActive;
        public int EntitiesCount { get;  }
        internal HkSimulationIslandInfo(HkSimulationIslandRef @ref) 
        { 
            this.m_handle = @ref;
            this.IsActive = this.m_handle.IsActive();
            this.m_handle.GetBounds(out this.AABB);
        }
        public HkSimulationIslandInfo(bool isActive, BoundingBox AABB, IntPtr handle) { /* Initialize Jolt Equivalent Here */ }
    }
}
