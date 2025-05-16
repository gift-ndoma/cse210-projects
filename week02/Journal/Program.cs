/*
 * Enhancement: Motivational Quotes Feature
 * ----------------------------------------
 * To encourage consistent journaling and help overcome common barriers 
 * like lack of motivation, this program displays a random motivational 
 * quote each time it starts. These quotes aim to inspire users to write 
 * in their journal by providing positive reminders and encouragement.
 *
 * This feature goes beyond the core requirements by adding a user-friendly 
 * element that supports engagement and habit-building in journaling.
 */
 
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        MotivationalQuote quote = new MotivationalQuote();

        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine("Here's a motivational quote for you today:");
        Console.WriteLine($"\"{quote.GetRandomQuote()}\"");
        Console.WriteLine();

        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            userChoice = int.Parse(choice);

            if (userChoice == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("\nYour Journal Entries:");
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
            }
        }
    }
}
