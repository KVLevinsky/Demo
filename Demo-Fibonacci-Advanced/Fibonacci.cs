using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Fibonacci_Advanced {
    class Fibonacci {
        protected Dictionary<ulong, ulong> cache = new Dictionary<ulong, ulong>();
        public ulong Evaluate(ulong value) {
            if (cache.TryGetValue(value, out ulong cachedValue)) return cachedValue;
            if (value > 0) {
                if (value == 1 || value == 2) return 1;
                else {
                    ulong result = Evaluate(value - 1) + Evaluate(value - 2);
                    cache[value] = result;
                    return result;
                }
            } else return 0;
        }
    }
}
