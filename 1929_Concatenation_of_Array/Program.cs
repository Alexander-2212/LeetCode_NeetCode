using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929_Concatenation_of_Array
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                ans[nums.Length + i] = nums[i];
            }

            return ans;
        }
    }

    public class Solution2
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[nums.Length + i] = nums[i];
            }

            return ans;
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
