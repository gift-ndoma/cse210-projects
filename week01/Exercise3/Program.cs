using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the magic number
        Console.Write("Enter the Magic Number: ");
        string magicInput = Console.ReadLine();
        float magicNumber = int.Parse(magicInput);

        //Asks the user for guess
        Console.Write("Enter your guess: ");
        string guessInput = Console.ReadLine();
        float guess = int.Parse(guessInput);

        if (guess < magicNumber) {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber) {
            Console.WriteLine("Lower!");
        }
        else {
            Console.WriteLine("You guessed it!");
        }
    }
}