using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is the grade percentage?: ");
        int grade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Grade=[{grade}]");
        
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if ( grade >= 80 )
        {
            letter = "B";
        }
        else if ( grade >= 70 )
        {
            letter = "C";
        }
        else if ( grade >= 60 )
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int unit = grade % 10;
        if ( unit >= 7)
        {
            sign = "+";
        }
        else if ( unit < 3)
        {
            sign = "-";
        }

        string letterAndSign = letter;

        if ( letter == "A")
        {
            if( sign == "+" )
            {
                sign = "";
            }
        }
        else if ( letter == "F")
        {
            sign = "";
        }

        letterAndSign += sign;

        Console.WriteLine($"Your Grade is {letterAndSign}");

        if ( letter == "A" || letter == "B" || letter == "C" )
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class this time, but don't be discouraged! Keep working hard, and you'll improve. Success comes with persistence!");
        }


    }
}