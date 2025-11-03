using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int inInterval = 0;
        int outInterval = 0;

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                inInterval++;
            }
            else
            {
                outInterval++;
            }
        }

        Console.WriteLine($"{inInterval} in");
        Console.WriteLine($"{outInterval} out");
    }
}