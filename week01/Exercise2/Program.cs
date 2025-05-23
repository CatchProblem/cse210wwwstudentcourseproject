using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their grade percentage
            Console.Write("Enter your grade percentage: ");
            int percentage = int.Parse(Console.ReadLine());

            // Determine the letter grade
            string letter = "";
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine if they passed the course
            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
            }

            // Stretch Challenge: Add "+" or "-" to the grade
            string sign = "";
            int lastDigit = percentage % 10;

            if (letter != "F")
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            // Handle special cases like A+ and F+/F-
            if (letter == "A" && sign == "+")
            {
                sign = ""; // No A+
            }
            else if (letter == "F")
            {
                sign = ""; // No F+ or F-
            }

            // Display the final grade
            Console.WriteLine($"Your final grade is: {letter}{sign}");
        }
    }
}
