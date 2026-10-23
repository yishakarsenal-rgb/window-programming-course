using System;

namespace Exercise24Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 56, 8, 97, 14, 10, 3, 5 };

            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("12, 56, 8, 97, 14, 10, 3, 5");
            Console.WriteLine("num of even integers = {0}", evenCount);
            Console.WriteLine("num of odd integers =  {0}", oddCount);

            Console.ReadKey();
        }
    }
}