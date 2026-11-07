using System;

namespace Chapter3_Exercise11
{
    public class Human
    {
        protected string first_name;
        protected string last_name;

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public Human() { }

        public Human(string fName, string lName)
        {
            first_name = fName;
            last_name = lName;
        }
    }

    class Student : Human
    {
        private int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Student(string fName, string lName, int m) : base(fName, lName)
        {
            mark = m;
        }
    }

    class Worker : Human
    {
        private double wage;
        private double hours;

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Worker(string fName, string lName, double w, double h) : base(fName, lName)
        {
            wage = w;
            hours = h;
        }

        public double CalculateHourlyWage()
        {
            if (hours == 0) return 0;
            return wage / hours;
        }

        public double CalculateTotalPay()
        {
            return wage * hours;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("dawit", "tadesse", 92);
            Console.WriteLine("student info");
            Console.WriteLine("name= {0} {1}, mark= {2}", st.First_name, st.Last_name, st.Mark);
            Worker wk = new Worker("hana", "Alemu", 250, 8);
            Console.WriteLine("\nworker info ---");
            Console.WriteLine("name= {0} {1}", wk.First_name, wk.Last_name);
            Console.WriteLine("wage= {0}, hours= {1}", wk.Wage, wk.Hours);
            Console.WriteLine("calculated pay (wage * hours)= {0}", wk.CalculateTotalPay());
            Console.WriteLine("hourly rate (wage / hours)=    {0:F2}", wk.CalculateHourlyWage());
            Console.ReadKey();
        }
    }
}