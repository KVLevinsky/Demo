using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Factorial {
    class Program {
        static void Main(string[] args) {
            ulong Number = 1;
            if (args.Length > 0)
                ulong.TryParse(args[0], out Number);
            Console.WriteLine($"Evaluating the factorial of {Number}...");
            Console.WriteLine($"{Number}! = {new Factorial().Evaluate(Number)}");
            Console.ReadKey();
        }
    }
}
