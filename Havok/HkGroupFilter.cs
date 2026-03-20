using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkGroupFilter {
        public static object CalcFilterInfo(int layer, int systemGroup, int subSystemId, int subSystemDontCollideWith) => throw new NotImplementedException();
        public static object CalcFilterInfo(int layer, int systemGroup) => throw new NotImplementedException();
        public static int GetSystemGroupFromFilterInfo(object filterInfo) => throw new NotImplementedException();
        public int GetNewSystemGroup() => throw new NotImplementedException();
        public HkGroupFilter(IntPtr ptr) { /* Initialize Jolt Equivalent Here */ }
    }
}
