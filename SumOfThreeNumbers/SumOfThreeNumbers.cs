using System;
using System.Globalization;
using System.Threading;


class SumOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", firstNumber + secondNumber + thirdNumber);
    }
}
