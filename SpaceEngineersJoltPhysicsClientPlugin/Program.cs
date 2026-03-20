using System.Reflection;
using HarmonyLib;
using VRage.Plugins;

namespace SpaceEngineersJoltPhysicsClientPlugin
{
    public class Plugin : IPlugin
    {
        public void Init(object gameInstance)
        {
            new Harmony(nameof(SpaceEngineersJoltPhysicsClientPlugin)).PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {
        }

        public void Dispose()
        {
        }
    }
}