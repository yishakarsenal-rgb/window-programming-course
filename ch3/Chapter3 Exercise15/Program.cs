using System;

namespace Chapter3_Exercise15
{
    abstract class Employee
    {
        private string name;
        private double baseSalary;

        public Employee(string name, double baseSalary)
        {
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public abstract double calculateSalary();
        public abstract void displayInfo();
    }

    class Manager : Employee
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Manager(string name, double baseSalary, double bonus)
            : base(name, baseSalary)
        {
            this.bonus = bonus;
        }

        public override double calculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void displayInfo()
        {
            Console.WriteLine("--- Manager Information ---");
            Console.WriteLine("Name:         {0}", Name);
            Console.WriteLine("Base Salary:  {0:C}", BaseSalary);
            Console.WriteLine("Bonus:        {0:C}", Bonus);
            Console.WriteLine("Total Salary: {0:C}\n", calculateSalary());
        }
    }

    class Programmer : Employee
    {
        private double overtimeHours;
        private double hourlyRate;

        public double OvertimeHours
        {
            get { return overtimeHours; }
            set { overtimeHours = value; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public Programmer(string name, double baseSalary, double overtimeHours, double hourlyRate)
            : base(name, baseSalary)
        {
            this.overtimeHours = overtimeHours;
            this.hourlyRate = hourlyRate;
        }

        public override double calculateSalary()
        {
            return BaseSalary + (OvertimeHours * HourlyRate);
        }

        public override void displayInfo()
        {
            Console.WriteLine("--- Programmer Information ---");
            Console.WriteLine("Name:           {0}", Name);
            Console.WriteLine("Base Salary:    {0:C}", BaseSalary);
            Console.WriteLine("Overtime Hours: {0}", OvertimeHours);
            Console.WriteLine("Hourly Rate:    {0:C}", HourlyRate);
            Console.WriteLine("Total Salary:   {0:C}\n", calculateSalary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager("Abebe Kebede", 35000.00, 7500.00);
            Programmer prog = new Programmer("Yishak Mekuannent", 28000.00, 15, 400.00);

            mgr.displayInfo();
            prog.displayInfo();

            Console.ReadKey();
        }
    }
}