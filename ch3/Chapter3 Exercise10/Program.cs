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
        // Static field holding number of created objects
        public static int StudentCount = 0;

        // Default Constructor
        public Student()
        {
            StudentCount++;
        }

        // Constructor with partial information
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

        // Constructor with complete information
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

        // Encapsulated Properties
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string Course { get { return course; } set { course = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string University { get { return university; } set { university = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Full Name:    {0}", FullName);
            Console.WriteLine("Course:       {0}", Course);
            Console.WriteLine("Subject:      {0}", Subject);
            Console.WriteLine("University:   {0}", University);
            Console.WriteLine("E-mail:       {0}", Email);
            Console.WriteLine("Phone Number: {0}", PhoneNumber);
        }
    }

    class StudentTest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Yishak Mekuannent", "Computer Science", "Windows Programming", "Unity University", "yishak@example.com", "+251911000000");
            Student s2 = new Student("Abebe Kebede", "Software Engineering", "Addis Ababa University");

            s1.DisplayStudentInfo();
            s2.DisplayStudentInfo();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total Student Objects Created: {0}", Student.StudentCount);

            Console.ReadKey();
        }
    }
}