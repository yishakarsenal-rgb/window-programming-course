using System;
namespace Chapter3_Exercise10
{
    class Student
    {
        private string fullName;
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phoneNumber;
        public static int StudentCount = 0;
        public Student()
        {
            StudentCount++;
        }
        public Student(string fullName, string course, string university)
        {
            this.fullName = fullName;
            this.course = course;
            this.university = university;
            this.subject = "N/A";
            this.email = "N/A";
            this.phoneNumber = "N/A";
            StudentCount++;
        }
        public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phoneNumber = phoneNumber;
            StudentCount++;
        }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string Course { get { return course; } set { course = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string University { get { return university; } set { university = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("full name=    {0}", FullName);
            Console.WriteLine("course=       {0}", Course);
            Console.WriteLine("subject=      {0}", Subject);
            Console.WriteLine("university=   {0}", University);
            Console.WriteLine("e-mail=       {0}", Email);
            Console.WriteLine("phone number= {0}", PhoneNumber);
        }
    }
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("yishak mekuannent", "computer science", "windows programming", "unity university", "yishak123@gmail.com", "+251913234334");
            Student s2 = new Student("abebe abel", "Software Engineering", "Addis Ababa University");
            s1.DisplayStudentInfo();
            s2.DisplayStudentInfo();
            Console.WriteLine("total student objects created= {0}", Student.StudentCount);
            Console.ReadKey();
        }
    }
}