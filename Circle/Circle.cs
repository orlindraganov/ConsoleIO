using System;
using System.Globalization;
using System.Threading;


class Circle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F} {1:F}", 2*Math.PI*radius, Math.PI*radius*radius);
    }
}
