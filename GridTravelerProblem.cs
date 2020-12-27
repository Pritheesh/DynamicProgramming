using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class GridTravelerProblem
    {
        private static ulong GridTraveler(int m, int n, Dictionary<string, ulong> dict = null)
        {
            if (dict == null) dict = new Dictionary<string, ulong>();
            var key = m + "," + n;
            if (dict.ContainsKey(key)) return dict.GetValueOrDefault(key);

            if (m == 0 || n == 0) return 0;
            if (m == 1 || n == 1) return 1;

            var value = GridTraveler(m - 1, n, dict) + GridTraveler(m, n - 1, dict);
            dict[key] = value;

            return value;
        }

        public static void GridTravelerStub()
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
