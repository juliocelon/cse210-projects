using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        fraction1.SetTop(3);
        fraction1.SetBottom(4);
        Console.WriteLine($"Top: {fraction1.GetTop()}");
        Console.WriteLine($"Bottom: {fraction1.GetBottom()}");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

    }
}