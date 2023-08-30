using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_Contains_Duplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (!dictionary.ContainsKey(n))
                    dictionary[n] = 0;
                dictionary[n]++;
            }

            foreach (var pair in dictionary)
                if (pair.Value > 1)
                    return true;

            return false;
        }
    }

    public class Solution2
    {
        public bool ContainsDuplicate(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    return true;
                }

            }
            return false;
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
