using System.Text;
using VRage.Library.Threading;

namespace Havok {
    public partial class HkBaseSystem {
        public static string GameName { get;  }
        public static string ThreadName { get;  }
        public static bool IsMainThread { get;  }
        public static bool IsThreadInitialized { get;  }
        public static bool DestructionEnabled { get;  }
        public static bool IsInitialized { get; set;  }
        public static bool IsSimulating { get; set;  }
        public static bool IsOutOfMemory { get;  }
        public static void Init(Action<string> LogCallback, bool deepProfilingEnabled, ISharedCriticalSection hkShapeCriticalSection) => throw new NotImplementedException();
        public static void Init(int solverMemorySize, Action<string> LogCallback, bool deepProfiling, ISharedCriticalSection hkShapeCriticalSection) => throw new NotImplementedException();
        public static void Quit() => throw new NotImplementedException();
        public static void InitThread(string name) => throw new NotImplementedException();
        public static void QuitThread() => throw new NotImplementedException();
        public static string[] GetKeyCodes() => throw new NotImplementedException();
        public static void GetMemoryStatistics(StringBuilder output) => throw new NotImplementedException();
        public static void EnableAssert(int assertId, bool enable) => throw new NotImplementedException();
        public static long GetCurrentMemoryConsumption() => throw new NotImplementedException();
        public static void OnSimulationFrameStarted(long staticSimulationFrameCounter) => throw new NotImplementedException();
        public static void OnSimulationFrameFinished() => throw new NotImplementedException();
    }
}
