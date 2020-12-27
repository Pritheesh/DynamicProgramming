using System;
using System.Collections.Generic;

namespace DynamicProgramming
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

        public static void Stub()
        {
            Console.WriteLine("--------------BestSum Begin---------------");
            BestSum(7, new List<int> { 5, 3, 4, 7 }).PrintList();
            BestSum(7, new List<int> { 2, 3 }).PrintList();
            BestSum(8, new List<int> { 1, 4, 5 }).PrintList();
            BestSum(8, new List<int> { 2, 3, 5 }).PrintList();
            BestSum(100, new List<int> { 1, 2, 5, 25 }).PrintList();
            BestSum(7, new List<int> { 2, 4 }).PrintList();
            BestSum(8, new List<int> { 2, 3, 5 }).PrintList();
            BestSum(300, new List<int> { 7, 14 }).PrintList();
            Console.WriteLine("--------------BestSum End---------------");
        }

    }
}
