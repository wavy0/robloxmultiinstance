using System;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting multi-instance in 3 seconds.");
            Thread.Sleep(3000);
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Multi-instance started!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Do ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("NOT ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("close this window, otherwise all Roblox windows except one will close.");
            Thread.Sleep(-1);
        }
    }
}
