using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class BestSumTabulationProblem
    {
        private static int[] BestSum(int target, List<int> array)
        {
            var result = new int[target + 1][];

            result[0] = new int[0];

            for (int i = 0; i <= target; i++)
            {
                var resultOfI = result[i];
                if (resultOfI != null)
                {
                    var length = resultOfI.Length;
                    foreach (var value in array)
                    {
                        var nextIndex = i + value;
                        if (nextIndex <= target &&
                            (result[nextIndex] == null || result[nextIndex].Length > length))
                            {
                                var dummy = new int[length + 1];
                                resultOfI.CopyTo(dummy, 0);
                                dummy[length] = value;
                                result[nextIndex] = dummy;
                            }
                    }
                }
            }

            return result[target];
        }

        public static void Stub()
        {
            Console.WriteLine("--------------BestSum Tabulation Begin---------------");
            BestSum(7, new List<int> { 5, 3, 4, 7 }).PrintList();
            BestSum(7, new List<int> { 2, 3 }).PrintList();
            BestSum(8, new List<int> { 1, 4, 5 }).PrintList();
            BestSum(8, new List<int> { 2, 3, 5 }).PrintList();
            BestSum(100, new List<int> { 1, 2, 5, 25 }).PrintList();
            BestSum(7, new List<int> { 2, 4 }).PrintList();
            BestSum(8, new List<int> { 2, 3, 5 }).PrintList();
            BestSum(300, new List<int> { 7, 14 }).PrintList();
            Console.WriteLine("--------------BestSum Tabulation End---------------");
        }
    }
}
