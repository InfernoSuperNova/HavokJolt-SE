using TorchInterface;

namespace SpaceEngineersJoltPhysics;

/// <summary>
/// Dynamically loads SEJolt.Body.dll at runtime.
/// This allows SEJolt.Torch (net48) to use SEJolt.Body (net10.0) without a direct compile-time reference.
/// </summary>
public static class PluginBodyLoader
{
    private static System.Reflection.Assembly _pluginBodyAssembly;

    /// <summary>
    /// Loads the SEJolt.Body assembly from the plugin output directory.
    /// </summary>
    /// <returns>The loaded assembly, or null if loading failed.</returns>
    public static System.Reflection.Assembly LoadPluginBody()
    {
        if (_pluginBodyAssembly != null)
            return _pluginBodyAssembly;

        try
        {
            // Get the directory where this plugin is running from
            var pluginDir = System.IO.Path.GetDirectoryName(typeof(Plugin).Assembly.Location);
            if (pluginDir == null)
            {
                System.Console.WriteLine("[PluginBodyLoader] Failed to determine plugin directory");
                return null;
            }

            var pluginBodyPath = System.IO.Path.Combine(pluginDir, "SEJolt.Body.dll");

            if (!System.IO.File.Exists(pluginBodyPath))
            {
                System.Console.WriteLine($"[PluginBodyLoader] SEJolt.Body.dll not found at {pluginBodyPath}");
                return null;
            }

            // Load the assembly
            _pluginBodyAssembly = System.Reflection.Assembly.LoadFrom(pluginBodyPath);
            System.Console.WriteLine($"[PluginBodyLoader] Successfully loaded SEJolt.Body from {pluginBodyPath}");

            return _pluginBodyAssembly;
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine($"[PluginBodyLoader] Failed to load SEJolt.Body: {ex}");
            return null;
        }
    }

    /// <summary>
    /// Gets a type from the SEJolt.Body assembly by name.
    /// </summary>
    public static System.Type GetType(string typeName)
    {
        var assembly = LoadPluginBody();
        if (assembly == null)
            return null;

        try
        {
            return assembly.GetType(typeName);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine($"[PluginBodyLoader] Failed to get type {typeName}: {ex}");
            return null;
        }
    }

    /// <summary>
    /// Creates an instance of a type from SEJolt.Body.
    /// </summary>
    public static object CreateInstance(string typeName, params object[] args)
    {
        var type = GetType(typeName);
        if (type == null)
            return null;

        try
        {
            return System.Activator.CreateInstance(type, args);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine($"[PluginBodyLoader] Failed to create instance of {typeName}: {ex}");
            return null;
        }
    }
}
