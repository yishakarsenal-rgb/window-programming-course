using System;

namespace Exercise22Application
{
    class Program
    {
        static void CountFrequency(int[] arr)
        {
            bool[] visited = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                Console.WriteLine("{0} occurs {1} times", arr[i], count);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter elements in the array (separated by space)=");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                arr[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("\noutput:");
            CountFrequency(arr);

            Console.ReadKey();
        }
    }
}