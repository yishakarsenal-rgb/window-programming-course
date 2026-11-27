using System;

namespace Chapter4_Extra7_Rethrow
{
    class Program
    {
        static void WithdrawFunds(double balance, double amount)
        {
            try
            {
                if (amount > balance)
                {
                    throw new InvalidOperationException("Withdrawal exceeds available balance.");
                }
                Console.WriteLine("Remaining balance: " + (balance - amount));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("[Audit Log in WithdrawFunds]: " + ex.Message);
                throw; // Re-throws the exact exception up the call stack
            }
        }

        static void Main(string[] args)
        {
            try
            {
                WithdrawFunds(1000.0, 2500.0);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("[User Alert in Main]: Transaction failed -> " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}