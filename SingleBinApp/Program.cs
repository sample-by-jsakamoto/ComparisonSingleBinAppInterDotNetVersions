using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using SingleBinApp;
using static Toolbelt.AnsiEscCode.Colorize;

class Program
{
    static void Main(string[] args)
    {
        AnsiCodeEnabler.Enable();

        Console.WriteLine(Yellow(RuntimeInformation.FrameworkDescription));
        Console.WriteLine();

        Console.WriteLine("AppContext.BaseDirectory:");
        Console.WriteLine(Cyan($"  [{AppContext.BaseDirectory}]"));
        Console.WriteLine();

        Console.WriteLine("AppDomain.CurrentDomain.BaseDirectory:");
        Console.WriteLine(Cyan($"  [{AppDomain.CurrentDomain.BaseDirectory}]"));
        Console.WriteLine();

        Console.WriteLine("Assembly.GetEntryAssembly().Location:");
        Console.WriteLine(Cyan($"  [{Assembly.GetEntryAssembly().Location}]"));
        Console.WriteLine();

        Console.WriteLine("Process.GetCurrentProcess().MainModule.FileName:");
        Console.WriteLine(Cyan($"  [{Process.GetCurrentProcess().MainModule.FileName}]"));

        Console.WriteLine();
        Console.WriteLine("Press ESC key...");
        while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape) ;
    }
}
