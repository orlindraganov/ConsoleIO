using System;
using System.Globalization;
using System.Threading;



class QuadraticEquations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        double firstAnswer = (-b - Math.Sqrt(d)) / (2 * a);
        double secondAnswer = (-b + Math.Sqrt(d)) / (2 * a);
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (firstAnswer == secondAnswer)
        {
            Console.WriteLine(firstAnswer.ToString("F"));
        }
        else
        {
            Console.WriteLine((firstAnswer < secondAnswer ? "{0:F}\r\n{1:F}" : "{1:F}\r\n{0:F}"), firstAnswer, secondAnswer);
        }
    }
}

