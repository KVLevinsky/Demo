using MathOperationsStringed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            string op1 = "123456789012345678901234567890";
            string op2 = "9876543210987654321098765432109";
            Console.WriteLine(MOS.ReverseString(MOS.Normalize(op1, 1 + Math.Max(op1.Length, op2.Length))));
            Console.WriteLine("+");
            Console.WriteLine(MOS.ReverseString(MOS.Normalize(op2, 1 + Math.Max(op1.Length, op2.Length))));
            Console.WriteLine(new string('-', Math.Max(op1.Length, op2.Length)));
            Console.WriteLine(MOS.Add(op1, op2));
            Console.ReadLine();
        }
    }
}
