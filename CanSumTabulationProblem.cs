using System;

namespace DynamicProgramming
{
    public static class CanSumTabulationProblem
    {
        private static bool CanSum(int target, int[] array)
        {
            var result = new bool[target + 1];

            result[0] = true;

            for (int i = 0; i <= target; i++)
            {
                if (result[i])
                    foreach (var value in array)
                    {
                        if (i + value <= target) result[i + value] = true;
                    }
            }


            return result[target];
        }

        public static void Stub()
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
