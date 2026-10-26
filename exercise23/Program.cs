using System;

namespace Exercise23Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter elements in the array separated by space=");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                arr[i] = int.Parse(parts[i]);
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("max element is = {0}", max);
            Console.WriteLine("min element is = {0}", min);

            Console.ReadKey();
        }
    }
}