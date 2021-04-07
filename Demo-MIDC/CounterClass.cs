using System;

namespace Demo_MIDC {
    internal class CounterClass {
        protected int steps;

        public CounterClass(int steps) {
            this.steps = steps;
        }

        public void Run() {
            for (int i = 0; i < steps; i++)
                Console.WriteLine(Increment(i));
        }

        public int Increment(int value) {
            Test("Method test invocation in the CounterClass");
            return value + 1;
        }

        public string Test(string property) {
            return property;
        }
    }
}