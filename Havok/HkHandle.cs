namespace Havok {
    public partial class HkHandle {
        public IntPtr NativeObject { get;  }
        public bool IsDisposed { get;  }
        public void Dispose() => throw new NotImplementedException();
        public void Dispose(bool disposing) => throw new NotImplementedException();
        public static int GetHandlesAmount() => throw new NotImplementedException();
        public HkHandle() { /* Initialize Jolt Equivalent Here */ }
        public HkHandle(IntPtr ptr, bool track) { /* Initialize Jolt Equivalent Here */ }
    }
}
