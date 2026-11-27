using System;

namespace Chapter4_Exercise7
{
    public class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException() : base("Invalid Number") { }
        public InvalidNumberException(string message) : base(message) { }
        public InvalidNumberException(string message, Exception inner) : base(message, inner) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new InvalidNumberException("Invalid Number");
                }
                double sqrt = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is: {1:F2}", number, sqrt);
            }
            catch (InvalidNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
            Console.ReadKey();
        }
    }
}