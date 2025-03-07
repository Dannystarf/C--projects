using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // bool enterNumber = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n");

        int enumber;

        while (true)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            if (!int.TryParse(number, out enumber))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            if (enumber != 0)
            {
                numbers.Add(enumber);
            }
            else
            {
                break;
            }

        }

        Console.WriteLine();

        int sum = 0;
        int largest = numbers[0];
        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }

            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"\nThe average is: {average}");
        Console.WriteLine($"\nThe largest number is: {largest}");

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("\nNo positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"\nThe smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();

        Console.WriteLine("\nThe sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + " ");
        }
    }   
}