using Jolt;
using VRage.Plugins;
using VRage.Utils;

namespace PulsarInterface;

public class Plugin : IPlugin   
{
    public void Init(object gameInstance) => SeJolt.Init(MyLog.Default);
    public void Update() => SeJolt.Update();
    public void Dispose() => SeJolt.Shutdown();
}
