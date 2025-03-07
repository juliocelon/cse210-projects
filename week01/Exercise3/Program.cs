using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /*
        Console.Write("What is the magic number?: ");
        int magicNumber = int.Parse(Console.ReadLine());
        */

        string wantToPlayAgain = "no";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int tryCounter=0;
            do 
            {
                Console.Write("What is your guess?:");
                guess = int.Parse(Console.ReadLine());

                if ( guess > magicNumber )
                {
                    System.Console.WriteLine("Lower");
                }
                else if ( guess < magicNumber )
                {
                    System.Console.WriteLine("Higher");
                }
                else
                {
                    System.Console.WriteLine("You guessed it!");
                }

                tryCounter++;

            } while ( guess != magicNumber );

            System.Console.WriteLine($"Number fo tries:{tryCounter}");

            System.Console.WriteLine("Do you wan to play again? (yes/no): ");
            wantToPlayAgain = Console.ReadLine();

        } while ( wantToPlayAgain == "yes");
    }
}