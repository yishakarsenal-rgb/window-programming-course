using System;

namespace problem1  
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Choose an operation (+, -, *, /): ");
                char operation = char.Parse(Console.ReadLine());
                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("cannot divide by zero");
                        }
                        result = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("invalid operation selected");
                }

                Console.WriteLine($"result= {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution complete.");
            }
            Console.ReadKey();
        }
    }
}