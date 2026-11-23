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

            // Enforces strict inequality: start < num < end[cite: 10]
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
                    // Remaining numbers need room before 100, so upper bound ensures sequence can finish
                    numbers[i] = ReadNumber(currentStart, maxLimit);
                    currentStart = numbers[i]; // Next number must be greater than the previous one[cite: 10]
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