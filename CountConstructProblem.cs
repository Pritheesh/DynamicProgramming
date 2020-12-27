using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class CountConstructProblem
    {
        private static int CountConstruct(string target, List<string> array, Dictionary<string, int> dict = null)
        {
            if (dict == null) dict = new Dictionary<string, int>();
            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);

            if (string.IsNullOrEmpty(target)) return 1;

            var totalCount = 0;

            foreach (var val in array)
            {
                if (target.StartsWith(val))
                {
                    totalCount += CountConstruct(target.Substring(val.Length), array, dict);
                }
            }

            dict.Add(target, totalCount);
            return totalCount;
        }

        public static void CountConstructStub()
        {
            Console.WriteLine("--------------CountConstruct Begin---------------");
            Console.WriteLine(CountConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CountConstruct("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CountConstruct("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" }));
            Console.WriteLine(CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeg",
                new List<string> { "eg", "ee", "eee", "eeee", "eeeee", "eeeeeee", "eeeeeeeee" }));
            Console.WriteLine("--------------CanConstruct End---------------");
        }
    }
}
