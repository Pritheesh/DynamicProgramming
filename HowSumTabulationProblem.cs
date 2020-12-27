using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class HowSumTabulationProblem
    {
        private static int[] HowSum(int target, List<int> array)
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
                        if (i + value <= target)
                        {
                            var dummy = new int[length + 1];
                            resultOfI.CopyTo(dummy, 0);
                            dummy[length] = value;
                            result[i + value] = dummy;
                        }
                    }
                }
            }

            return result[target];
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
