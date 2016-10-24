using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 4, 7, 10 };
            int[] array2 = { 1, 5, 6, 8, 11, 12, 14 };

            MergeArrays(array1, array2);
            Console.ReadLine();
        }

        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int count1 = array1.Length;
            int count2 = array2.Length;

            int[] sortedArray = new int[count1 + count2];

            int a = 0;
            int b = 0;
            int i = 0;

            while (a < count1 && b < count2)
            {
                if (array1[a] <= array2[b])
                {
                    sortedArray[i++] = array1[a++];
                }
                else
                {
                    sortedArray[i++] = array2[b++];
                }
            }

            if (a < count1)
            {
                for (int j = a; j < count1; j++)
                {
                    sortedArray[i++] = array1[j];
                }
            }
            else
            {
                for (int j = b; j < count2; j++)
                {
                    sortedArray[i++] = array2[j];
                }
            }
            Console.WriteLine("Result is{{ {0}}}", string.Join(",", sortedArray.Select(e => e.ToString())));
            return sortedArray;
        }
    }
}
