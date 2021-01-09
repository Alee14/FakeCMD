using System;
using Microsoft.Win32;

namespace FakeCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Microsoft Windows [Version {Environment.OSVersion.Version}]");
            Console.WriteLine("(c) 2020 Microsoft Corporation. All rights reserved.");
#if DEBUG
            Console.WriteLine("\nYou are running .NET {0}", Environment.Version.ToString());
#endif
            Console.ReadLine();
        }
    }
}
