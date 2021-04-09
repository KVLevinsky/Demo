using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Fibonacci_Advanced {
    class Program {
        static void Main(string[] args) {
            ulong Number = 1;
            if (args.Length > 0)
                ulong.TryParse(args[0], out Number);
            Console.WriteLine($"Evaluating the {Number}-{GetEnding(Number)} Fibonacci number value...");
            Console.WriteLine($"{Number}-{GetEnding(Number)} Fibonacci number value is {new Fibonacci().Evaluate(Number)}");
            Console.Write("The sequence:");
            for (ulong i = 1; i <= Number; i++)
                Console.Write($" {new Fibonacci().Evaluate(i)}");
            Console.ReadKey();
        }

        private static string GetEnding(ulong number) {
            if (number == 1) return "st";
            if (number == 2) return "nd";
            if (number == 3) return "rd";
            return "th";
        }
    }
}
