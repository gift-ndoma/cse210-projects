using System;

class Program
{
    static void Main(string[] args)
    {   
        float guess = -1;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guesses = 0; 

        string choice = "yes";

        while (choice.ToLower() == "yes") {

            //Asks the user for guess
            Console.Write("Enter your guess: ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            guesses += 1;

            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber) {
                Console.WriteLine("Lower!");
            }
            else {
                Console.WriteLine($"You guessed it!. It took you {guesses} guesses.");
                Console.Write("Do you want to keep playing? ");
                choice = Console.ReadLine().ToLower();

                if (choice == "yes") {
                    magicNumber = randomGenerator.Next(1, 101);
                    guesses = 0;
                }
            }
            
        }
    }
}