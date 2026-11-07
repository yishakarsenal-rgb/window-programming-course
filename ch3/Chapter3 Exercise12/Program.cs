using System;
namespace Chapter3_Exercise12
{
    class Member
    {
        public string Name;
        public int Age;
        public string PhoneNumber;
        public string Address;
        public double Salary;

        public void PrintSalary()
        {
            Console.WriteLine("Salary:         {0:C}", Salary);
        }
    }
    class Employee : Member
    {
        public string specialization;

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Name:           {0}", Name);
            Console.WriteLine("Age:            {0}", Age);
            Console.WriteLine("Phone Number:   {0}", PhoneNumber);
            Console.WriteLine("Address:        {0}", Address);
            Console.WriteLine("Specialization: {0}", specialization);
            PrintSalary();
        }
    }
    class Manager : Member
    {
        public string department;

        public void DisplayManager()
        {
            Console.WriteLine("\n--- Manager Details ---");
            Console.WriteLine("Name:           {0}", Name);
            Console.WriteLine("Age:            {0}", Age);
            Console.WriteLine("Phone Number:   {0}", PhoneNumber);
            Console.WriteLine("Address:        {0}", Address);
            Console.WriteLine("Department:     {0}", department);
            PrintSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Biniyam Tesfaye";
            emp.Age = 25;
            emp.PhoneNumber = "0911223344";
            emp.Address = "Bole, Addis Ababa";
            emp.Salary = 25000.00;
            emp.specialization = "Backend Development";
            Manager mgr = new Manager();
            mgr.Name = "Selamawit Bekele";
            mgr.Age = 34;
            mgr.PhoneNumber = "0922334455";
            mgr.Address = "Kazanchis, Addis Ababa";
            mgr.Salary = 45000.00;
            mgr.department = "IT & Engineering";
            emp.DisplayEmployee();
            mgr.DisplayManager();
            Console.ReadKey();
        }
    }
}