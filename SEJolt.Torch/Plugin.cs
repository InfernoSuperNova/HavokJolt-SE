using System.IO;
using System.Windows.Controls;
using SpaceEngineersJoltPhysics;
using Torch;
using Torch.API;
using Torch.API.Plugins;
using Torch.Views;
using VRage.Utils;

namespace TorchInterface;

public class Plugin : TorchPluginBase, IWpfPlugin
{
    private Persistent<Config> _config = null!;
    private MyLog _log = null!;

    public override void Init(ITorchBase torch)
    {
        base.Init(torch);
        _config = Persistent<Config>.Load(Path.Combine(StoragePath, "SEJolt.Torch.cfg"));

        _log = MyLog.Default;
        // Load and initialize SEJolt.Body
        InitializePluginBody(_log);
    }

    public override void Update()
    {
        // Call SEJolt.Body update
        UpdatePluginBody();
    }

    public override void Dispose()
    {
        // Shutdown SEJolt.Body
        ShutdownPluginBody();
        base.Dispose();
    }

    public UserControl GetControl() => new PropertyGrid
    {
        Margin = new(3),
        DataContext = _config.Data
    };

    /// <summary>
    /// Initializes SEJolt.Body by loading it dynamically and calling its Init method.
    /// </summary>
    private void InitializePluginBody(MyLog log)
    {
        try
        {
            var assembly = PluginBodyLoader.LoadPluginBody();
            if (assembly == null)
            {
                log.Error("Failed to load SEJolt.Body assembly");
                return;
            }

            // Get the SEJolt type from SEJolt.Body
            var seJoltType = PluginBodyLoader.GetType("SEJolt");
            if (seJoltType == null)
            {
                log.Error("Failed to find SEJolt type in SEJolt.Body");
                return;
            }

            // Call SEJolt.Init()
            var initMethod = seJoltType.GetMethod("Init", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            if (initMethod == null)
            {
                log.Error("Failed to find Init method on SEJolt");
                return;
            }

            initMethod.Invoke(null, new object[] { log });
            log.Info("SEJolt.Body initialized successfully");
        }
        catch (System.Exception ex)
        {
            log.Error($"Error initializing SEJolt.Body: {ex}");
        }
    }

    /// <summary>
    /// Updates SEJolt.Body by calling its Update method.
    /// </summary>
    private void UpdatePluginBody()
    {
        try
        {
            var seJoltType = PluginBodyLoader.GetType("SEJolt");
            if (seJoltType == null)
                return;

            var updateMethod = seJoltType.GetMethod("Update", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            if (updateMethod == null)
                return;

            updateMethod.Invoke(null, null);
        }
        catch (System.Exception ex)
        {
            _log.Error($"Error updating SEJolt.Body: {ex}");
        }
    }

    /// <summary>
    /// Shuts down SEJolt.Body by calling its Shutdown method.
    /// </summary>
    private void ShutdownPluginBody()
    {
        try
        {
            var seJoltType = PluginBodyLoader.GetType("SEJolt");
            if (seJoltType == null)
                return;

            var shutdownMethod = seJoltType.GetMethod("Shutdown", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            if (shutdownMethod == null)
                return;

            shutdownMethod.Invoke(null, null);
            _log.Info("SEJolt.Body shut down successfully");
        }
        catch (System.Exception ex)
        {
            _log.Error($"Error shutting down SEJolt.Body: {ex}");
        }
    }
}