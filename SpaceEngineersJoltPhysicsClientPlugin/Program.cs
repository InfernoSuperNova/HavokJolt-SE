using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using VRage.Plugins;

namespace SpaceEngineersJoltPhysicsClientPlugin
{
    public class Plugin : IPlugin
    {
        private Assembly _ourTargetAssembly;

        public void Init(object gameInstance)
        {
            _ourTargetAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "Havok");
            
            if (_ourTargetAssembly == null)
            {
                var havokType = typeof(Havok.HkWorld);
                _ourTargetAssembly = havokType.Assembly;
            }
            
            AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
            
            new Harmony(nameof(SpaceEngineersJoltPhysicsClientPlugin)).PatchAll(Assembly.GetExecutingAssembly());
        }

        private Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            
            if (assemblyName.Name == "HavokWrapper")
            {
                return _ourTargetAssembly;
            }

            return null;
        }

        public void Update()
        {
        }

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyResolve -= OnAssemblyResolve;
        }
    }
}