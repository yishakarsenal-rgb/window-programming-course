using System;

namespace Exercise25Application
{
    class Program
    {
        static int secondLargestElement(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 2];
        }

        static void Main(string[] args)
        {
            int[] myNumbers = { 12, 3, 5, 10 };

            Console.WriteLine("second largest from 12, 3, 5, 10 = {0}", secondLargestElement(myNumbers));
            Console.ReadKey();
        }
    }
}