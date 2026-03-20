namespace Havok {
    public partial class HkReferenceObject {
        public static bool CollectStackTraces { get; set;  }
        public int ReferenceCount { get;  }
        public void ClearHandle() => throw new NotImplementedException();
        public HkReferenceObject(IntPtr referenceObj, bool track) { /* Initialize Jolt Equivalent Here */ }
        public HkReferenceObject() { /* Initialize Jolt Equivalent Here */ }
    }
}
