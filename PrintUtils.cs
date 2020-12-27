using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    public static class PrintUtils
    {
        public static void PrintListOfLists<T>(this IEnumerable<IEnumerable<T>> items)
        {
            if (!HandleNull(items))
            {
                Console.WriteLine("[");
                items.ToList().ForEach(item => { Console.Write("   "); PrintList(item); });
                Console.WriteLine("]");
            }
        }

        public static void PrintList<T>(this IEnumerable<T> items)
        {
            if (!HandleNull(items))
            {
                Console.Write("[");
                Console.Write(string.Join(", ", items));
                Console.WriteLine("]");
            }
        }

        private static bool HandleNull<T>(T item)
        {
            if (item == null)
            {
                Console.WriteLine("null");
                return true;
            }
            return false;
        }
    }
}
