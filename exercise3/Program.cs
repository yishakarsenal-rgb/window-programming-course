using System;

namespace Exercise3Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Values of expressions (Slide 34)
            Console.WriteLine("--- Part 1: Expression Values ---");
            Console.WriteLine("10 / 3 = {0}       (Integer division truncates decimal)", 10 / 3);
            Console.WriteLine("5.2 / 2.0 = {0}  (Floating-point division)", 5.2 / 2.0);
            Console.WriteLine("9 % 3 = {0}        (Remainder of 9 divided by 3)", 9 % 3);

            // Part 2: Order of evaluation and result of X = 2 * 5 / 3 + 3 * 5 + 7
            // Precedence rule (Slide 30-31): * and / have higher precedence than + and =,
            // and binary operators (*, /, +) are evaluated left-to-right.
            // Step 1: 2 * 5 = 10
            // Step 2: 10 / 3 = 3 (integer division)
            // Step 3: 3 * 5 = 15
            // Step 4: 3 + 15 = 18
            // Step 5: 18 + 7 = 25
            // Step 6: X = 25 (Assignment '=' is evaluated last)
            int X = 2 * 5 / 3 + 3 * 5 + 7;

            Console.WriteLine("\n--- Part 2: Operator Precedence ---");
            Console.WriteLine("Expression: X = 2 * 5 / 3 + 3 * 5 + 7");
            Console.WriteLine("Step 1 (2 * 5)   -> 10");
            Console.WriteLine("Step 2 (10 / 3)  -> 3");
            Console.WriteLine("Step 3 (3 * 5)   -> 15");
            Console.WriteLine("Step 4 (3 + 15)  -> 18");
            Console.WriteLine("Step 5 (18 + 7)  -> 25");
            Console.WriteLine("Step 6 (X = 25)  -> Final Value of X: {0}", X);

            Console.ReadKey();
        }
    }
}