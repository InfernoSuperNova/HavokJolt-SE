using System.Runtime.InteropServices;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkCollisionEvent {
        public IntPtr NativeObject { get;  }
        public CallbackSource Source { get;  }
        public HkRigidBody BodyA { get;  }
        public HkRigidBody BodyB { get;  }
        public int NrContactPoints { get;  }
        public HkRigidBody GetRigidBody(int bodyIndex) => throw new NotImplementedException();
        public HkCollisionEvent(IntPtr inHandle) { /* Initialize Jolt Equivalent Here */ }
        public void Disable() => throw new NotImplementedException();
        public HkContactPointProperties GetContactPointPropertiesAt(int i) => throw new NotImplementedException();
    }
    
    public enum CallbackSource
    {
        A,
        B,
        World,
    }
}
