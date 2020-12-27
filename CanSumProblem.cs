using System;
using System.Collections.Generic;

namespace HowSum
{
    public static class CanSumProblem
    {
        private static bool CanSum(int target, int[] array, Dictionary<int, bool> dict = null)
        {
            if (dict == null)
                dict = new Dictionary<int, bool>();

            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);
            if (target == 0) return true;
            if (target < 0) return false;

            foreach (var i in array)
            {
                if (CanSum(target - i, array, dict))
                {
                    dict.Add(target, true);
                    return true;
                }
            }

            dict.Add(target, false);
            return false;
        }

        public static void CanSumStub()
        {
            Console.WriteLine("--------------CanSum Begin---------------");
            Console.WriteLine(CanSum(7, new[] { 4, 5, 3, 7 }));
            Console.WriteLine(CanSum(8, new[] { 4, 5, 3, 7 }));
            Console.WriteLine(CanSum(17, new[] { 4, 5, 3, 7 }));
            Console.WriteLine(CanSum(15, new[] { 4, 2, 6 }));
            Console.WriteLine(CanSum(300, new[] { 7, 14 }));
            Console.WriteLine("--------------CanSum End---------------");
        }
    }
}
