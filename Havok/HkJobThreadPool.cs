namespace Havok {
    public partial class HkJobThreadPool {
        public int ThreadCount { get;  }
        public HkJobThreadPool() { /* Initialize Jolt Equivalent Here */ }
        public HkJobThreadPool(int threadCount) { /* Initialize Jolt Equivalent Here */ }
        public void ExecuteJobQueue(HkJobQueue jobQueue) => throw new NotImplementedException();
        public int GetThisThreadIndex() => throw new NotImplementedException();
        public void WaitForCompletion() => throw new NotImplementedException();
    }
}
