using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        
        if (!int.TryParse(userNumber, out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return PromptUserNumber();
        }

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    static void Main()
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
