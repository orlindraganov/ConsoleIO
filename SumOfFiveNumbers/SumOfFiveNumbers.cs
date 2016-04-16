using System;

class SumOfFiveNumbers

{
    static void Main()
    {
        int number = 0;
        for (int i = 0; i < 5; i++)
        {
            number += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(number);
    }
}
