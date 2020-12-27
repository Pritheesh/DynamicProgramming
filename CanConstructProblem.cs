using System;
using System.Collections.Generic;

namespace HowSum
{
    public static class CanConstructProblem
    {
        private static bool CanConstruct(string target, List<string> array, Dictionary<string, bool> dict = null)
        {
            if (dict == null) dict = new Dictionary<string, bool>();
            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);
            if (string.IsNullOrEmpty(target)) return true;

            foreach (var val in array)
            {
                if (target.StartsWith(val) && CanConstruct(target.Substring(val.Length), array, dict))
                {
                    dict.Add(target, true);
                    return true;
                }
            }

            dict.Add(target, false);
            return false;
        }

        public static void CanConstructStub()
        {
            Console.WriteLine("--------------CanConstruct Begin---------------");
            Console.WriteLine(CanConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CanConstruct("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CanConstruct("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" }));
            Console.WriteLine(CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeg", 
                new List<string> { "e", "ee", "eee", "eeee", "eeeee", "eeeeeee", "eeeeeeeee" }));
            Console.WriteLine("--------------CanConstruct End---------------");
        }
    }
}
