using System;
using Microsoft.Win32;

namespace FakeCMD
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("You are running .NET {0}", Environment.Version.ToString());
#endif
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var buildNumber = registryKey.GetValue("UBR").ToString();
            Console.WriteLine($"Microsoft Windows [Version {buildNumber}]");
            Console.ReadLine();
        }
    }
}
