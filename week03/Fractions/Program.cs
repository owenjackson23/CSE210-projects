using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3, 4);

        string firstFraction = first.GetFractionString();
        double firstDecimal = first.GetDecimalValue();
        Console.WriteLine(firstFraction);
        Console.WriteLine(firstDecimal);

        string secondFraction = second.GetFractionString();
        double secondDecimal = second.GetDecimalValue();
        Console.WriteLine(secondFraction);
        Console.WriteLine(secondDecimal);

        string thirdFraction = third.GetFractionString();
        double thirdDecimal = third.GetDecimalValue();
        Console.WriteLine(thirdFraction);
        Console.WriteLine(thirdDecimal);

        third.SetTop(1);
        third.SetBottom(3);
        thirdFraction = third.GetFractionString();
        thirdDecimal = third.GetDecimalValue();
        Console.WriteLine(thirdFraction);
        Console.WriteLine(thirdDecimal);
    }
}