//Beyond Requirements:
// 1. Journal entries are saved in CSV format, making them easily accessible in spreadsheet applications.
//    Special care has been taken to handle commas and quotes correctly in text fields.
// 2. Added a search function to allow users to find journal entries by keyword,
//    making it easier to reflect on past thoughts based on specific themes or events.

using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Search journal");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch (choice)

            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response));
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    myJournal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    myJournal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Enter keyword to search: ");
                    myJournal.SearchEntries(Console.ReadLine());
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
             
        }
    }
}