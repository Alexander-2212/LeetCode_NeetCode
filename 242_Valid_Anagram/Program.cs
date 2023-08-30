using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242_Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();

            Array.Sort(sArr);
            Array.Sort(tArr);

            return sArr.SequenceEqual(tArr) ? true : false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
