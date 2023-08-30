using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392_Is_Subsequence
{
    public class Solution //TODO: Optimize result set
    {
        public bool IsSubsequence(string s, string t)
        {
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            int counter = 0;

            for (int i = 0; i < sChars.Length; i++)
            {
                if (tChars.Contains(sChars[i]))
                {
                    counter++;
                }
            }

            return counter == sChars.Length;
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
