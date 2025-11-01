using System;

class Program
{
    static void Main(string[] args)
    {
        // get first name from the user
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        //get last name from the user
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        //Print name in the format firstname, firstname lastname
        Console.WriteLine($"Your name is {firstName}, {firstName} {lastName}");
    }
}