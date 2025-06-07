using System;

class Program
{
    static void Main(string[] args)
    {
        // Enhancement: Added a reflection quote at the end to inspire the user and provide a thoughtful close to the activity
        int userInput = 0;
        
        while (userInput != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput == 1)
                {
                    Console.Clear();
                    BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                    activity1.Run();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                    activity2.Run();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);
                    activity3.Run();
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}