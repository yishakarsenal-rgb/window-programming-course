using System;
namespace Chapter3_Exercise9
{
    class Month
    {
        private int monthNumber;
        public int MonthNumber
        {
            get { return monthNumber; }
            set { monthNumber = value; }
        }
        public string GetMonthName()
        {
            switch (monthNumber)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "invalid month";
            }
        }
        public int GetDaysInMonth()
        {
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    return 0;
            }
        }
        public string DisplayDetail()
        {
            if (monthNumber < 1 || monthNumber > 12)
            {
                return "please enter number between 1 and 12";
            }
            return string.Format("month= {0}, number of days= {1}", GetMonthName(), GetDaysInMonth());
        }
    }
    class TestMonth
    {
        static void Main(string[] args)
        {
            Month m = new Month();
            Console.Write("enter month(1 - 12)= ");
            m.MonthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m.DisplayDetail());
            Console.ReadKey();
        }
    }
}