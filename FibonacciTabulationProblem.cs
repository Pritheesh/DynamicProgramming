using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class FibonacciTabulationProblem
    {
        private static ulong Fibonacci(int n)
        {
            ulong[] result = new ulong[n + 1];

            result[1] = 1;

            for (var i = 0; i <= n; i++)
            {
                var current = result[i];
                if (i + 1 <= n) result[i + 1] += current;
                if (i + 2 <= n) result[i + 2] += current;
            }

            return result[n];
        }

        public static void Stub()
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
