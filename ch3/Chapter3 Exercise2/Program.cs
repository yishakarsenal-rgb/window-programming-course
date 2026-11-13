using System;
namespace Chapter3_Exercise2
{
    class Person
    {
        private string name;
        private int age;
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
        public void PrintData()
        {
            Console.WriteLine("name= {0} and age= {1}", name, age);
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("yishak", 22);
            Person p2 = new Person("henok", 21);
            p1.PrintData();
            p2.PrintData();
            Console.ReadKey();
        }
    }
}