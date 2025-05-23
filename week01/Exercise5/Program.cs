using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();
        
        // Call the PromptUserName function and save the returned value
        string userName = PromptUserName();
        
        // Call the PromptUserNumber function and save the returned value
        int favoriteNumber = PromptUserNumber();
        
        // Call the SquareNumber function and save the returned value
        int squaredNumber = SquareNumber(favoriteNumber);
        
        // Call the DisplayResult function to display the final message
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square a number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
