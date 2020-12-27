using System;
using System.Collections.Generic;

namespace HowSum
{
    public static class FibonacciProblem
    {
        private static ulong Fibonacci(int n, Dictionary<int, ulong> dict = null)
        {
            if (dict == null) dict = new Dictionary<int, ulong>();
            if (dict.ContainsKey(n)) return dict.GetValueOrDefault(n);

            if (n <= 2) return 1;

            var current = Fibonacci(n - 1, dict) + Fibonacci(n - 2, dict);
            dict.Add(n, current);

            return current;
        }

        public static void FibonacciStub()
        {
            Console.WriteLine("--------------Fibonacci Begin---------------");
            Console.WriteLine(Fibonacci(7));
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(Fibonacci(11));
            Console.WriteLine(Fibonacci(50));
            Console.WriteLine("--------------Fibonacci End---------------");
        }
    }
}
