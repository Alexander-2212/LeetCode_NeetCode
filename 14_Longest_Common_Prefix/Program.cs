using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Longest_Common_Prefix
{
    static class Solution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            //if (strs.Length == 0)
            //    return "";

            //string prefix = strs[0];

            //for (int i = 1; i < strs.Length; i++)
            //{
            //    while (strs[i].IndexOf(prefix) != 0)
            //    {
            //        prefix = prefix.Substring(0, strs.Length - 1);
            //        if (string.IsNullOrEmpty(prefix))
            //            return "";
            //    }

            //}

            //return prefix;

            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs);

            string first = strs[0];
            string last = strs[strs.Length - 1];

            int i = 0;

            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }

            return first.Substring(0, i);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            string[] strs2 = { "dog", "racecar", "car" };

            Console.WriteLine(Solution.LongestCommonPrefix(strs));
            Console.WriteLine(Solution.LongestCommonPrefix(strs2));

            Console.ReadKey();
        }
    }
}
