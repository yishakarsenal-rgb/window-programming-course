using System;

namespace Exercise2Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Abebe";
            string lastName = "Kebede";
            byte age = 28;                  // byte (0 to 255) or int is appropriate for age
            char gender = 'm';              // char for single character 'm' or 'f'
            int employeeNumber = 27560001;  // int holds values from 27560000 to 27569999

            // Displaying the employee record using Slide 11/86 formatting
            Console.WriteLine("--- Employee Data Record ---");
            Console.WriteLine("First Name:      {0}", firstName);
            Console.WriteLine("Last Name:       {0}", lastName);
            Console.WriteLine("Age:             {0}", age);
            Console.WriteLine("Gender:          {0}", gender);
            Console.WriteLine("Employee Number: {0}", employeeNumber);

            Console.ReadKey();
        }
    }
}