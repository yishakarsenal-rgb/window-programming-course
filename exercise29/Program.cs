using System;

namespace Exercise29Application
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            string cleanStr = str.Replace(" ", "").ToLower();

            string reversedStr = "";
            for (int i = cleanStr.Length - 1; i >= 0; i--)
            {
                reversedStr += cleanStr[i];
            }

            return cleanStr == reversedStr;
        }

        static void Main(string[] args)
        {
            Console.Write("enter word = ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("\"{0}\" is palindrome.", input);
            }
            else
            {
                Console.WriteLine("\"{0}\" is not palindrome.", input);
            }

            Console.ReadKey();
        }
    }
}