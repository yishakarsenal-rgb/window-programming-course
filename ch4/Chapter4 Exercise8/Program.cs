using System;

namespace Chapter4_Exercise8
{
    public class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException() : base() { }
        public InvalidNumberException(string message) : base(message) { }
        public InvalidNumberException(string message, Exception inner) : base(message, inner) { }
    }
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            Console.Write($"Enter an integer strictly between {start} and {end} (valid range [{start + 1}..{end - 1}]): ");
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                throw new InvalidNumberException("Input is not a valid integer.", ex);
            }
            if (num <= start || num >= end)
            {
                throw new InvalidNumberException($"Number {num} is out of range! Must be > {start} and < {end}.");
            }
            return num;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int currentStart = 1;
            int maxLimit = 100;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = ReadNumber(currentStart, maxLimit);
                    currentStart = numbers[i]; 
                }
                Console.WriteLine("\nSuccessfully read all 10 strictly increasing numbers:");
                Console.WriteLine(string.Join(" < ", numbers));
            }
            catch (InvalidNumberException ex)
            {
                Console.WriteLine($"\nInvalidNumberException: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}