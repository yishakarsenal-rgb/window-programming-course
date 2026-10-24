using System;

namespace Exercise28Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter string : ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    string firstLetter = words[i].Substring(0, 1).ToUpper();
                    string restOfWord = words[i].Substring(1);
                    result += firstLetter + restOfWord + " ";
                }
            }

            Console.WriteLine("enter with first letter uppercase= {0}", result.Trim());

            Console.ReadKey();
        }
    }
}