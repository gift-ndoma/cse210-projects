using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own undersanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words have been hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}