// Space Engineers JoltPhysics.Wrappers Physics — HavokWrapper Usage Analyzer
//
// Run after game updates to detect new/changed/removed Havok call sites.
//
// Usage:
//   csc tools/analyze_havok_usage.cs -out:tools/analyze_havok_usage.exe
//   mono tools/analyze_havok_usage.exe [--se-path /path/to/SpaceEngineers/Bin64] [--baseline tools/baseline.txt] [--output tools/baseline.txt]
//
// Without arguments, auto-detects the SE install path and prints a full report.
// With --baseline, compares against a previous run and shows added/removed methods.
// With --output, saves the current state as a new baseline file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

class AnalyzeHavokUsage
{
    static string FindSEBin64()
    {
        var home = Environment.GetEnvironmentVariable("HOME") ?? "";
        var candidates = new[]
        {
            Path.Combine(home, ".steam/steam/steamapps/common/SpaceEngineers/Bin64"),
            Path.Combine(home, ".steam/debian-installation/steamapps/common/SpaceEngineers/Bin64"),
            Path.Combine(home, ".local/share/Steam/steamapps/common/SpaceEngineers/Bin64"),
            @"C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Bin64",
            @"D:\SteamLibrary\steamapps\common\SpaceEngineers\Bin64",
        };
        foreach (var c in candidates)
            if (Directory.Exists(c)) return c;
        return null;
    }

    static List<string> AnalyzeAssemblies(string bin64)
    {
        var havokWrapper = Assembly.LoadFrom(Path.Combine(bin64, "HavokWrapper.dll"));
        var asmNames = new[] { "Sandbox.Game.dll", "SpaceEngineers.Game.dll", "VRage.Game.dll" };
        var results = new List<string>();

        foreach (var asmName in asmNames)
        {
            var asmPath = Path.Combine(bin64, asmName);
            if (!File.Exists(asmPath)) { Console.Error.WriteLine($"WARNING: {asmName} not found"); continue; }

            var asm = Assembly.LoadFrom(asmPath);
            foreach (var type in asm.GetTypes())
            {
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
                {
                    try
                    {
                        bool usesHavok = false;
                        if (method.ReturnType.Assembly == havokWrapper) usesHavok = true;
                        if (!usesHavok)
                            foreach (var p in method.GetParameters())
                                if (p.ParameterType.Assembly == havokWrapper) { usesHavok = true; break; }
                        if (!usesHavok)
                        {
                            var body = method.GetMethodBody();
                            if (body != null)
                                foreach (var l in body.LocalVariables)
                                    if (l.LocalType.Assembly == havokWrapper) { usesHavok = true; break; }
                        }

                        if (usesHavok)
                        {
                            var parms = string.Join(", ", method.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name));
                            var vis = method.IsPublic ? "public" : method.IsPrivate ? "private" : "protected";
                            var stat = method.IsStatic ? "static " : "";
                            var sig = $"{asmName}|{type.FullName}|{vis} {stat}{method.ReturnType.Name} {method.Name}({parms})";
                            results.Add(sig);
                        }
                    }
                    catch { }
                }
            }
        }

        return results;
    }

    static void PrintFullReport(List<string> entries)
    {
        var byAssembly = entries.GroupBy(e => e.Split('|')[0]).OrderBy(g => g.Key);

        Console.WriteLine("=============================================================");
        Console.WriteLine("  HavokWrapper Usage Report");
        Console.WriteLine($"  Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine("=============================================================\n");

        int totalMethods = 0;
        int totalClasses = 0;

        foreach (var asmGroup in byAssembly)
        {
            var byClass = asmGroup.GroupBy(e => e.Split('|')[1]).OrderByDescending(g => g.Count());
            int asmMethods = asmGroup.Count();
            int asmClasses = byClass.Count();
            totalMethods += asmMethods;
            totalClasses += asmClasses;

            Console.WriteLine($"--- {asmGroup.Key}: {asmMethods} methods across {asmClasses} classes ---\n");

            foreach (var classGroup in byClass)
            {
                Console.WriteLine($"  {classGroup.Key} ({classGroup.Count()} methods)");
                foreach (var entry in classGroup)
                {
                    var sig = entry.Split('|')[2];
                    Console.WriteLine($"    {sig}");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine("=============================================================");
        Console.WriteLine($"  TOTAL: {totalMethods} methods across {totalClasses} classes");
        Console.WriteLine("=============================================================");
    }

    static void PrintDiff(List<string> current, List<string> baseline)
    {
        var currentSet = new HashSet<string>(current);
        var baselineSet = new HashSet<string>(baseline);

        var added = current.Where(e => !baselineSet.Contains(e)).ToList();
        var removed = baseline.Where(e => !currentSet.Contains(e)).ToList();

        Console.WriteLine("=============================================================");
        Console.WriteLine("  HavokWrapper Usage DIFF Report");
        Console.WriteLine($"  Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"  Baseline: {baseline.Count} methods | Current: {current.Count} methods");
        Console.WriteLine("=============================================================\n");

        if (added.Count == 0 && removed.Count == 0)
        {
            Console.WriteLine("  No changes detected! All clear.\n");
            return;
        }

        if (added.Count > 0)
        {
            Console.WriteLine($"  +++ ADDED ({added.Count} new methods using HavokWrapper) +++\n");
            foreach (var entry in added)
            {
                var parts = entry.Split('|');
                Console.WriteLine($"    [{parts[0]}] {parts[1]}");
                Console.WriteLine($"      {parts[2]}");
            }
            Console.WriteLine();
        }

        if (removed.Count > 0)
        {
            Console.WriteLine($"  --- REMOVED ({removed.Count} methods no longer using HavokWrapper) ---\n");
            foreach (var entry in removed)
            {
                var parts = entry.Split('|');
                Console.WriteLine($"    [{parts[0]}] {parts[1]}");
                Console.WriteLine($"      {parts[2]}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=============================================================");
        Console.WriteLine($"  Summary: +{added.Count} added, -{removed.Count} removed");
        Console.WriteLine("=============================================================");
    }

    static void Main(string[] args)
    {
        string sePath = null;
        string baselinePath = null;
        string outputPath = null;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--se-path" && i + 1 < args.Length) sePath = args[++i];
            else if (args[i] == "--baseline" && i + 1 < args.Length) baselinePath = args[++i];
            else if (args[i] == "--output" && i + 1 < args.Length) outputPath = args[++i];
            else if (args[i] == "--help" || args[i] == "-h")
            {
                Console.WriteLine("Usage: analyze_havok_usage [options]");
                Console.WriteLine("  --se-path <path>     Path to SpaceEngineers/Bin64");
                Console.WriteLine("  --baseline <file>    Compare against baseline file");
                Console.WriteLine("  --output <file>      Save current state as baseline");
                Console.WriteLine("  --help               Show this help");
                return;
            }
        }

        if (sePath == null) sePath = FindSEBin64();
        if (sePath == null)
        {
            Console.Error.WriteLine("ERROR: Could not find Space Engineers installation.");
            Console.Error.WriteLine("Use --se-path to specify the Bin64 directory.");
            Environment.Exit(1);
        }

        Console.Error.WriteLine($"Using SE path: {sePath}");

        var current = AnalyzeAssemblies(sePath);

        if (outputPath != null)
        {
            File.WriteAllLines(outputPath, current);
            Console.Error.WriteLine($"Saved baseline to: {outputPath} ({current.Count} entries)");
        }

        if (baselinePath != null && File.Exists(baselinePath))
        {
            var baseline = File.ReadAllLines(baselinePath).Where(l => !string.IsNullOrWhiteSpace(l)).ToList();
            PrintDiff(current, baseline);
        }
        else
        {
            PrintFullReport(current);
        }
    }
}
