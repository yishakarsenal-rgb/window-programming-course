using System;

namespace Chapter4_Extra4_ArgumentValidation
{
    class Program
    {
        static void SetExamScore(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }
            Console.WriteLine("Recorded valid exam score: " + score);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter exam score (0-100): ");
                int inputScore = int.Parse(Console.ReadLine());
                SetExamScore(inputScore);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Range Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Error: Please enter an integer.");
            }

            Console.ReadKey();
        }
    }
}