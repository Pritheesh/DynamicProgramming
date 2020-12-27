using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class PrintUtils
    {
        public static void PrintListOfLists<T>(this List<IEnumerable<T>> items)
        {
            Console.WriteLine("[");
            items.ForEach(item => { Console.Write("   "); PrintList(item); });
            Console.WriteLine("]");
        }

        public static void PrintList<T>(this IEnumerable<T> items)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", items));
            Console.WriteLine("]");
        }
    }
}
