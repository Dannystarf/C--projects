using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        fname = char.ToUpper(fname[0]) + fname.Substring(1).ToLower();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        lname = char.ToUpper(lname[0]) + lname.Substring(1).ToLower();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}