using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class HowConstructProblem
    {
        private static List<string> HowConstruct(string target, List<string> array, Dictionary<string, List<string>> dict = null)
        {
            if (dict == null) dict = new Dictionary<string, List<string>>();
            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);
            if (string.IsNullOrEmpty(target)) return new List<string>();

            List<string> retVal = null;

            foreach (var val in array)
            {
                if (target.StartsWith(val))
                {
                    var stringlist = HowConstruct(target.Substring(val.Length), array, dict);
                    if (stringlist != null)
                    {
                        var combo = new List<string>(stringlist) { val };
                        if (retVal == null || retVal.Count > combo.Count)
                        {
                            dict.Add(target, combo);
                            return combo;
                        }
                    }
                }
            }

            dict.Add(target, retVal);
            return retVal;
        }

        public static void Stub()
        {
            Console.WriteLine("--------------HowConstruct Begin---------------");
            HowConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" }).PrintList();
            HowConstruct("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" }).PrintList();
            HowConstruct("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" }).PrintList();
            HowConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeg",
                new List<string> { "e", "ee", "eee", "eeee", "eeeee", "eeeeeee", "eeeeeeeee" }).PrintList();
            Console.WriteLine("--------------HowConstruct End---------------");
        }
    }
}
