using System;

namespace Exercise21Application
{
    class Program
    {
        static bool IfSortedAscending(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 3, 7, 10 };
            int[] arr2 = { 74, 62, 99 };

            Console.WriteLine("3, 7, 10 = {0}", IfSortedAscending(arr1));
            Console.WriteLine("74, 62, 99 = {0}", IfSortedAscending(arr2));

            Console.ReadKey();
        }
    }
}