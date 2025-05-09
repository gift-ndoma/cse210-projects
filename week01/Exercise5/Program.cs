using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int num = PromptUserNumber();
        int squareNum = SquareNumber(num);

        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);
        return number;
    }
    
    static int SquareNumber(int number) 
    {
        int numSquare = number * number;
        return numSquare;
    }

    static void DisplayResult(string name, int number) 
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}