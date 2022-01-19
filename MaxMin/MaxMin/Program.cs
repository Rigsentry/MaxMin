using System;
using System.Linq;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 4, 7, 2 };
            int k1 = 2;
            int[] array2 = new int[] { 10, 100, 300, 200, 1000, 20, 30 };
            int k2 = 3;
            int[] array3 = new int[] { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 };
            int k3 = 4;
            int[] array4 = new int[] { 1, 2, 1, 2, 1 };
            int k4 = 2;

            MaxMin(array1, k1);
            MaxMin(array2, k2);
            MaxMin(array3, k3);
            MaxMin(array4, k4);
        }

        public static void MaxMin(int[] arr, int k)
        {
            Array.Sort(arr);
            int unfairness = -1;
            int[] tempArr = new int[k]; ;

            for (int i = 0; i < (arr.Length - k); i++)
            {
                for(int j = 0; j < k; j++)
                {
                    tempArr[j] = arr[i + j];
                }
                if(unfairness == -1 || (tempArr.Max()- tempArr.Min()) < unfairness)
                {
                    unfairness = tempArr.Max() - tempArr.Min();
                }
            }

            Console.WriteLine(unfairness);
        }
    }
}
