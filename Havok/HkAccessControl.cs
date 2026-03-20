using System.Runtime.InteropServices;

namespace Havok {
    public partial class HkAccessControl {
        public static AccessState State { get; set;  }
        public static AccessStateToken PushState(AccessState newState) => throw new NotImplementedException();
        
        public enum AccessState
        {
            Exclusive,
            SharedRead,
        }
        
        public struct AccessStateToken : IDisposable
        {
            private readonly HkAccessControl.AccessState m_previousState;

            public AccessStateToken(HkAccessControl.AccessState newState)
            {
                this.m_previousState = HkAccessControl.State;
                HkAccessControl.State = newState;
            }

            public void Dispose() => HkAccessControl.State = this.m_previousState;
        }

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        internal readonly struct AccessToken : IDisposable
        {
            public AccessToken(AccessType access, bool taken, bool allowDuringSimulation = false)
            {
            }

            public void Dispose()
            {
            }
        }
        
        internal enum AccessType
        {
            Read,
            Write,
        }
    }
}
