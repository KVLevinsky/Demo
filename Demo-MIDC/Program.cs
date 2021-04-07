using Demo_MIDC.Properties;
using System;
using System.Threading;

namespace Demo_MIDC {
    class Program {
        static void Main(string[] args) {
            while (true) {
                CounterClass cc = new CounterClass(Settings.Default.Steps);
                cc.Run();

                Console.WriteLine("Increment cycle is over.\r\nSleeping for 5 seconds...");
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}
