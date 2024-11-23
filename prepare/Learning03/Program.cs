using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine("\nFraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine("\nFraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction3.GetDecimalValue());

        fraction3.SetNumerator(3);
        fraction3.SetDenominator(4);
        Console.WriteLine("\nUpdated Fraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Updated Decimal Value: " + fraction3.GetDecimalValue());
    }
}