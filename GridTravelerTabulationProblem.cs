using System;

namespace DynamicProgramming
{
    public static class GridTravelerTabulationProblem
    {
        private static ulong GridTraveler(int m, int n)
        {
            ulong[,] result = new ulong[m + 1, n + 1];

            result[1, 1] = 1;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    var current = result[i, j];
                    if (i + 1 <= m) result[i + 1, j] += current;
                    if (j + 1 <= n) result[i, j + 1] += current;
                }
            }

            return result[m, n];
        }

        public static void Stub()
        {
            Console.WriteLine("--------------GridTraveler Begin---------------");
            Console.WriteLine(GridTraveler(3, 3));
            Console.WriteLine(GridTraveler(2, 3));
            Console.WriteLine(GridTraveler(3, 2));
            Console.WriteLine(GridTraveler(2, 2));
            Console.WriteLine(GridTraveler(18, 18));
            Console.WriteLine("--------------GridTraveler End---------------");
        }
    }
}
