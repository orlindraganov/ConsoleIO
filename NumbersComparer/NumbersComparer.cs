using System;
using System.Globalization;
using System.Threading;


class NumbersComparer

{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine(firstNumber > secondNumber ?  firstNumber : secondNumber);
    }
}
