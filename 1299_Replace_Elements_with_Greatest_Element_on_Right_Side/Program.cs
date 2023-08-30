using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1299_Replace_Elements_with_Greatest_Element_on_Right_Side
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            int[] tempArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    tempArray[i] = -1;
                }

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= tempArray[i])
                    {
                        tempArray[i] = arr[j];
                    }
                }

            }
            return tempArray;
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
