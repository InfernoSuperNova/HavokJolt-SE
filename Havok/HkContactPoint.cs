using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkContactPoint {
        public IntPtr NativeObject { get;  }
        public Vector3 Position { get; set;  }
        public Vector4 NormalAndDistance { get; set;  }
        public Vector3 Normal { get; set;  }
        public float Distance { get; set;  }
        public void Flip() => throw new NotImplementedException();
        public HkContactPoint(IntPtr contactPoint) { /* Initialize Jolt Equivalent Here */ }
    }
}
