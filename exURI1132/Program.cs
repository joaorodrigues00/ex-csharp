using System;

public class URI
{
    static void Main(string[] args)
    {
        int x, y, initialIterationValue, lastIterationValue;
        int result = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            initialIterationValue = x;
            lastIterationValue = y;
        } else
        {
            initialIterationValue = y;
            lastIterationValue = x;
        }

        for (int i = initialIterationValue; i <= lastIterationValue; i++)
        {
            if (i % 13 != 0)
            {
                result += i ;
            }
        }

        Console.WriteLine($"{result}");
    }
}