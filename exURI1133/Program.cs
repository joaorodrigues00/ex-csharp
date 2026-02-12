using System;

public class URI
{
    static void Main(string[] args)
    {
        int x, y;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        int minValue = Math.Min(x, y);
        int maxValue = Math.Max(x, y);

        for (int i = minValue+1; i < maxValue; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}