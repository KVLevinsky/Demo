using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Factorial {
    class Factorial {
        public ulong Evaluate(ulong value) {
            if (value > 0) {
                if (value == 1) return 1;
                else return value * Evaluate(value - 1);
            } else return 0;
        }
    }
}
