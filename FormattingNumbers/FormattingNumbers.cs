using System;
using System.Globalization;
using System.Threading;



class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        string binaryFirst = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
        Console.WriteLine("{0:X} |{1}| {2,1:F}|{3,-1:F3} |", firstNumber, binaryFirst, secondNumber, thirdNumber);
    }
}
