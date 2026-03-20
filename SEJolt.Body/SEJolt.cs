using VRage.Utils;

namespace Jolt;

public static class SeJolt
{
    public static MyLog Log { get; private set; }
    
    public static void Init(MyLog log)
    {
        Log = log;
        Log.Info("SEJolt.Body initialized");
        JoltPhysicsDemo.Initialize(log);
    }
    public static void Update()
    {
        JoltPhysicsDemo.Step();
    }

    public static void Shutdown()
    {
        JoltPhysicsDemo.Shutdown();
        Log.Info("SEJolt.Body shutdown");
    }
 
}
