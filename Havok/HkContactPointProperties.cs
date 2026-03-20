using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkContactPointProperties {
        public IntPtr NativeObject { get;  }
        public float ImpulseApplied { get;  }
        public float InternalSolverData { get;  }
        public bool WasUsed { get;  }
        public float Friction { get; set;  }
        public float Restitution { get; set;  }
        public bool IsPotential { get;  }
        public float MaxImpulsePerStep { get; set;  }
        public HkContactUserData UserData { get; set;  }
        public float MaxImpulse { get; set;  }
        public bool IsDisabled { get; set;  }
        public bool IsNew { get; set;  }
        public HkContactPointProperties(IntPtr inHandle) { /* Initialize Jolt Equivalent Here */ }
    }
}
