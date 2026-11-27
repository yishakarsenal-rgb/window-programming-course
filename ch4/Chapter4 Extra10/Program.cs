using System;

namespace Chapter4_Extra10
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 500.00;
            try
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                {
                    throw new InsufficientBalanceException("Insufficient balance!");
                }
                balance -= amount;
                Console.WriteLine("Withdrawal successful! Remaining balance: " + balance);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            Console.ReadKey();
        }
    }
}