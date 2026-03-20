namespace Havok {
    public partial class HkJobQueue {
        public int ThreadCount { get;  }
        public WaitPolicyT WaitPolicy { get; set;  }
        public int MasterThreadFinishingFlags { get; set;  }
        public HkJobQueue() { /* Initialize Jolt Equivalent Here */ }
        public HkJobQueue(int threadCount) { /* Initialize Jolt Equivalent Here */ }
        public void ProcessAllJobs() => throw new NotImplementedException();
    }
    
    public enum WaitPolicyT
    {
        WAIT_UNTIL_ALL_WORK_COMPLETE,
        WAIT_INDEFINITELY,
    }
}
