using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}