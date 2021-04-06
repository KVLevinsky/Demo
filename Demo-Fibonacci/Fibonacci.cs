using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Fibonacci {
    class Fibonacci {
        public ulong Evaluate(ulong value) {
            if (value > 0) {
                if (value == 1 || value == 2) return 1;
                else return Evaluate(value - 1) + Evaluate(value - 2);
            } else return 0;
        }
    }
}
