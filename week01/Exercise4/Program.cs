using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> myList = new List<int>();
        int newValue = 0;
        int sum = 0;
        int largestNumber = 0;
        int smallestPositiveNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            newValue = int.Parse(Console.ReadLine());

            if(newValue != 0)
            {
                myList.Add(newValue);

                sum+=newValue;

                if ( newValue > largestNumber )
                    largestNumber = newValue;

                if( newValue > 0 )
                {
                    if(smallestPositiveNumber == 0)
                        smallestPositiveNumber = newValue;
                    else if(newValue < smallestPositiveNumber)
                        smallestPositiveNumber = newValue;
                }
            }

        }while(newValue != 0);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum/myList.Count}");
        Console.WriteLine($"The largest number is: {largestNumber}");

        // Another alternative to get the largest number
        //Console.WriteLine($"The largest number is: {myList.Max()}");

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        myList.Sort();
        foreach(int i in myList)
        {
            Console.WriteLine(i);
        }
    }
}