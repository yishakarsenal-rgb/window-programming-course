using System;

namespace Chapter3_Exercise14
{
    abstract class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;
            balance = initialBalance;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void deposit();
        public abstract void withdraw();
    }

    class SavingsAccount : BankAccount
    {
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public SavingsAccount(string accNum, double initialBalance, double transactionAmount)
            : base(accNum, initialBalance)
        {
            amount = transactionAmount;
        }

        public override void deposit()
        {
            if (Amount > 0)
            {
                Balance += Amount;
                Console.WriteLine("Deposited: {0:C}. New Balance: {1:C}", Amount, Balance);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public override void withdraw()
        {
            if (Amount > 0 && Amount <= Balance)
            {
                Balance -= Amount;
                Console.WriteLine("Withdrawn: {0:C}. Remaining Balance: {1:C}", Amount, Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount myAccount = new SavingsAccount("ETH-10002345", 5000.00, 1500.00);

            Console.WriteLine("Account Number:  {0}", myAccount.AccountNumber);
            Console.WriteLine("Initial Balance: {0:C}\n", myAccount.Balance);

            // Deposit 1500
            myAccount.deposit();

            // Change transaction amount to 2000 and withdraw
            myAccount.Amount = 2000.00;
            myAccount.withdraw();

            Console.ReadKey();
        }
    }
}