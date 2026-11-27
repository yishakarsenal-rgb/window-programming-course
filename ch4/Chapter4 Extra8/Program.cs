using System;

namespace Chapter4_Extra8
{
    public class StudentRecordException : ApplicationException
    {
        public StudentRecordException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    class Program
    {
        static void LoadStudentYear(string yearText)
        {
            try
            {
                int year = int.Parse(yearText);
                Console.WriteLine("Student Year: " + year);
            }
            catch (FormatException ex)
            {
                throw new StudentRecordException("Failed to load student academic year.", ex);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                LoadStudentYear("FourthYear");
            }
            catch (StudentRecordException ex)
            {
                Console.WriteLine("High-Level Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Root Cause ({0}): {1}",
                        ex.InnerException.GetType().Name,
                        ex.InnerException.Message);
                }
            }

            Console.ReadKey();
        }
    }
}