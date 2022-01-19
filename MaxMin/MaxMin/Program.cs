using System;
using System.Linq;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array = new int[] { 10, 100, 300, 200, 1000, 20, 30 };
            //var k = 3;

            //var array = new int[] { 1,2,3,4,10,20,30,40,100,200 };
            //var k = 4;

            var array = new int[] { 1, 2, 1, 2, 1 };
            var k = 4;

            Array.Sort(array);

            var unfairness = array[k - 1] - array[0];

            Console.WriteLine("The unfairness value is = " + unfairness);


        }
    }
}
