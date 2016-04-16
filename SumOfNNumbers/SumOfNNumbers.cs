using System;
using System.Globalization;
using System.Threading;


namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double number = 0;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                number += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}
