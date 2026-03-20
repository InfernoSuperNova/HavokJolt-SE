# SWEEP.md — Project Reference

## Project Overview
Replacing Space Engineers' Havok physics with Jolt Physics via Harmony patching of game-side
physics classes. Plugin is loaded by Pulsar (successor to Plugin Loader) which compiles plugins
on the fly AFTER game assemblies are already loaded — no DLL replacement possible.

## Strategy
Harmony-patch ~430 game methods across ~95 classes (not the 2,517 HavokWrapper members).
See PROGRESS.md for the full phased breakdown.

## Key Paths
- **SE Install**: Auto-detected, common locations:
  - `~/.steam/debian-installation/steamapps/common/SpaceEngineers/Bin64`
  - `~/.steam/steam/steamapps/common/SpaceEngineers/Bin64`
- **Game Assemblies Referencing HavokWrapper**: `Sandbox.Game.dll`, `SpaceEngineers.Game.dll`, `VRage.Game.dll`
- **HavokWrapper.dll**: Managed .NET assembly (netstandard2.0, NOT strong-named)
- **Havok.dll**: Native C++ DLL (not managed, not what we patch)

## Build Commands
```bash
# Build entire solution
dotnet build /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/SpaceEngineersJoltPhysics.sln

# Build individual projects
dotnet build /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/Havok/Havok.csproj
dotnet build /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/SpaceEngineersJoltPhysicsClientPlugin/SpaceEngineersJoltPhysicsClientPlugin.csproj
dotnet build /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/SpaceEngineersJoltPhysics/SpaceEngineersJoltPhysics.csproj
```

## Analysis Tools — Run After Game Updates
```bash
# Compile the analyzer (one-time)
csc /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.cs \
    -out:/home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.exe

# Full report (prints all methods using HavokWrapper)
mono /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.exe

# Save new baseline after game update
mono /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.exe \
    --output /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/baseline.txt

# Diff against previous baseline (shows added/removed methods)
mono /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.exe \
    --baseline /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/baseline.txt

# Diff and save new baseline in one go
mono /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/analyze_havok_usage.exe \
    --baseline /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/baseline.txt \
    --output /home/deltawing/RiderProjects/SpaceEngineersJoltPhysics/tools/baseline.txt
```

## Project Structure
- `Havok/` — Stub reimplementations of HavokWrapper types (may become unnecessary with game-side patching approach)
- `SpaceEngineersJoltPhysicsClientPlugin/` — Client-side Pulsar plugin (IPlugin, Harmony patches)
- `SpaceEngineersJoltPhysics/` — Server-side Torch plugin
- `tools/` — Analysis tools for tracking HavokWrapper usage across game updates
  - `analyze_havok_usage.cs` — Reflects over game DLLs, counts/diffs Havok call sites
  - `analyze_havok_usage.exe` — Compiled analyzer
  - `baseline.txt` — Last known state (430 methods, 95 classes as of initial analysis)

## Code Style
- .NET Framework 4.8 (net48), C# 7.3 for client plugin, C# 12 for other projects
- Harmony 2.2.2 for patching
- x64 platform target
- Uses PolySharp for polyfills in newer C# features on net48
