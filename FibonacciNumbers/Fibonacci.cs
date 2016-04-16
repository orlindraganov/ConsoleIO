using System;

class Fibonacci
{
    static void Main()
    {
        uint count = uint.Parse(Console.ReadLine());
        ulong number = 0;
        ulong prevNumber = 1;
        for (int i = 0; i < count; i++)
        {
            Console.Write(i < count - 1 ? "{0}, " : "{0}", number);
            number += prevNumber;
            prevNumber = number - prevNumber;
        }
        Console.WriteLine();
    }
}
