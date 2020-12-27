using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    public static class AllConstructProblem
    {
        private static List<IEnumerable<string>> AllConstruct(string target, List<string> array, Dictionary<string, List<IEnumerable<string>>> dict = null)
        {
            if (dict == null) dict = new Dictionary<string, List<IEnumerable<string>>>();
            if (dict.ContainsKey(target)) return dict.GetValueOrDefault(target);
            if (target == string.Empty) return new List<IEnumerable<string>>() { new List<string>() };

            IEnumerable<IEnumerable<string>> list = new List<IEnumerable<string>>();

            foreach (var value in array)
            {
                if (target.StartsWith(value))
                {
                    var suffix = target.Substring(value.Length);
                    var childList = AllConstruct(suffix, array, dict);
                    var subWays = childList.Select(e => e.Prepend(value));
                    list = list.Concat(subWays);

                }
            }

            dict.Add(target, list.ToList());
            return dict.GetValueOrDefault(target);
        }

        public static void Stub()
        {
            Console.WriteLine("--------------AllConstruct Begin---------------");
            AllConstruct("purple", new List<string> { "purp", "p", "ur", "le", "purpl" }).PrintListOfLists();
            AllConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd", "ef", "c" }).PrintListOfLists();
            AllConstruct("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" }).PrintListOfLists();
            AllConstruct("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" }).PrintListOfLists();
            AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
                new List<string> { "eg", "ee", "eee", "eeee", "eeeee", "eeeeeee", "eeeeeeeee" }).PrintListOfLists();
            Console.WriteLine("--------------AllConstruct End---------------");
        }
    }
}
