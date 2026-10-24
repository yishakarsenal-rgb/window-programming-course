using System;

namespace Exercise29Application
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            // Remove spaces and convert to lowercase using Replace and ToLower (Slides 78 & 84)
            // so phrases like "nurses run" also work properly
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
            Console.Write("Enter a word or phrase to check if it is a palindrome: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("\"{0}\" is a Palindrome.", input);
            }
            else
            {
                Console.WriteLine("\"{0}\" is NOT a Palindrome.", input);
            }

            Console.ReadKey();
        }
    }
}