using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int total = 0;
        int highestNum = -1;
        int lowestNum = 9999999;
        List<int> numberList = new List<int>();

        while (number != 0) {
            Console.Write("Enter your number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            if (number != 0) {

                numberList.Add(number);
                total += number;
                
                if (number > highestNum) {
                    highestNum = number;
                }

                if (number < lowestNum && number > 0) {
                    lowestNum = number;
                }
            }
        }
        Console.WriteLine($"The sum is: {total}");
        double average = (double)total / numberList.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest Number is: {highestNum}");
        Console.WriteLine($"The largest Number is: {lowestNum}");

        numberList.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numberList) {
            Console.WriteLine(num);
        }
    }
}