using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Length_of_Last_Word
{
    static class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            string temp = null;

            temp = s.Trim();

            string[] arr = temp.Split(' ');
            
            temp = arr[arr.Length - 1];

            return temp.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.LengthOfLastWord("luffy is still joyboy"));
            Console.WriteLine(Solution.LengthOfLastWord("   fly me   to   the moon  "));

            Console.ReadKey();
        }
    }
}
