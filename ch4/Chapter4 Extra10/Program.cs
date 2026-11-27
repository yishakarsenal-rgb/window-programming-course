using System;

namespace Chapter4_Extra10_CustomBankException
{
    public class InsufficientBalanceException : ApplicationException
    {
        public double CurrentBalance { get; }
        public double RequestedAmount { get; }

        public InsufficientBalanceException()
            : base("Insufficient funds for this transaction.") { }

        public InsufficientBalanceException(string message)
            : base(message) { }

        public InsufficientBalanceException(string message, Exception inner)
            : base(message, inner) { }

        public InsufficientBalanceException(double balance, double requested)
            : base($"Cannot withdraw {requested:C}. Available balance is {balance:C}.")
        {
            CurrentBalance = balance;
            RequestedAmount = requested;
        }
    }

    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientBalanceException(Balance, amount);
            }
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: {Balance:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(500.00);

            try
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: Please enter a valid numeric amount.");
            }

            Console.ReadKey();
        }
    }
}