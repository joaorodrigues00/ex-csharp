using System;

public class URI
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = 6 + i; j > 6 + i - 3; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}