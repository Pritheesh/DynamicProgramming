using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class HowSumProblem
    {
        private static List<int> HowSum(int target, List<int> array, Dictionary<int, List<int>> dict = null)
        {
            if (dict == null) dict = new Dictionary<int, List<int>>();

            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);

            if (target == 0) return new List<int>();
            if (target < 0) return null;

            foreach (var i in array)
            {
                var remainder = target - i;
                var val = HowSum(remainder, array, dict);
                if (val != null)
                {
                    val.Add(i);
                    dict.Add(target, val);
                    return val;
                }
            }

            dict.Add(target, null);
            return null;
        }

        public static void Stub()
        {
            Console.WriteLine("--------------HowSum Begin---------------");
           HowSum(7, new List<int> { 5, 3, 4, 7 }).PrintList();
           HowSum(7, new List<int> { 2, 3 }).PrintList();
           HowSum(7, new List<int> { 2, 4 }).PrintList();
           HowSum(8, new List<int> { 2, 3, 5 }).PrintList();
           HowSum(300, new List<int> { 7, 14 }).PrintList();
            Console.WriteLine("--------------HowSum End---------------");
        }
    }
}
