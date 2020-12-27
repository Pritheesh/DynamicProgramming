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

        public static void HowConstructStub()
        {
            Console.WriteLine("--------------HowConstruct Begin---------------");
            Console.WriteLine(string.Join(", ", HowConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" })));
            Console.WriteLine(HowConstruct("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(string.Join(", ", HowConstruct("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })));
            Console.WriteLine(HowConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeg",
                new List<string> { "e", "ee", "eee", "eeee", "eeeee", "eeeeeee", "eeeeeeeee" }));
            Console.WriteLine("--------------HowConstruct End---------------");
        }
    }
}
