using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int mnumber = randomGenerator.Next(1, 100);

            Console.WriteLine("\nThere is a magic number stored, can you guess it? ");
            Console.WriteLine();

            int gnumber = 0;
            int gcount = 0; 

            while (gnumber != mnumber)
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                
                if (!int.TryParse(guessNumber, out gnumber))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    continue;
                }

                gcount++;
            
                if (gnumber > mnumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (gnumber < mnumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it!\nIn {gcount} attempts");
                }
            }

            Console.Write("\nDo you want to play again? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing! See you again.");
            }
        }
    }
}