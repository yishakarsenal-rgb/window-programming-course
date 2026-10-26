using System;

namespace Exercise26Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter string = ");
            string str = Console.ReadLine();

            int l = 0;
            int wordCount = 1;

            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wordCount++;
                }
                l++;
            }
            if (str.Trim().Length == 0)
            {
                wordCount = 0;
            }

            Console.WriteLine("total number of words in the string = {0}", wordCount);

            Console.ReadKey();
        }
    }
}