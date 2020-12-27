using System;
using System.Collections.Generic;

namespace HowSum
{
    public static class BestSumProblem
    {
        private static List<int> BestSum(int target, List<int> array, Dictionary<int, List<int>> dict = null)
        {
            if (dict == null) dict = new Dictionary<int, List<int>>();
            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);
            if (target == 0) return new List<int>();
            if (target < 0) return null;

            List<int> retVal = null;

            foreach (int val in array)
            {
                var remainder = target - val;
                var test = BestSum(remainder, array, dict);
                if (test != null)
                {
                    var bla = new List<int>(test) { val };
                    if (retVal == null || retVal.Count > test.Count)
                        retVal = bla;
                }
            }
            dict[target] = retVal;
            return retVal;
        }

        public static void BestSumStub()
        {
            Console.WriteLine("--------------BestSum Begin---------------");
            Console.WriteLine(string.Join(", ", BestSum(7, new List<int> { 5, 3, 4, 7 })));
            Console.WriteLine(string.Join(", ", BestSum(7, new List<int> { 2, 3 })));
            Console.WriteLine(string.Join(", ", BestSum(8, new List<int> { 1, 4, 5 })));
            Console.WriteLine(string.Join(", ", BestSum(8, new List<int> { 2, 3, 5 })));
            Console.WriteLine(string.Join(", ", BestSum(100, new List<int> { 1, 2, 5, 25 })));
            Console.WriteLine(string.Join(", ", BestSum(7, new List<int> { 2, 4 }) ?? new List<int> { }));
            Console.WriteLine(string.Join(", ", BestSum(8, new List<int> { 2, 3, 5 }) ?? new List<int> { }));
            Console.WriteLine(string.Join(", ", BestSum(300, new List<int> { 7, 14 }) ?? new List<int> { }));
            Console.WriteLine("--------------BestSum End---------------");
        }

    }
}
