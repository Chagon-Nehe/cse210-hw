using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your course percentage grade? ");
        string input = Console.ReadLine();
        double grade = Convert.ToDouble(input);
        string letter = "";


        if (grade >= 90)
        {
            if (grade >= 93)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }

        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade >= 83)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }


        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade >= 73)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }

        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade >= 63)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }

        }
        else
        {
            letter = "F";

        }

        Console.WriteLine($"Your letter grade is {letter}");
        
        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratulations!! You passed the course!");

        }
        else if (grade < 70 && grade >= 0)
        {
            Console.WriteLine("You did not pass the course.");
        }
        else
        {
            Console.WriteLine("Invalid grade entered.");

        }
    }
}