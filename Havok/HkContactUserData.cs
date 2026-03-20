using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkContactUserData {
        public object AsUint { get;  }
        public static HkContactUserData UInt(object value) => throw new NotImplementedException();
    }
}
