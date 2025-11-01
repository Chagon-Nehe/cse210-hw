using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Guess Number Game!");
        Random NumberGenerator = new Random();
        int magicNumber = NumberGenerator.Next(1, 101);
        
        Console.Write("Guess the magic number between 1 and 100: ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);
       
        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number between 1 and 100: ");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}