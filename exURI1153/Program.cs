using System;

public class URI
{
    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int fat = 1;

        for (int i = N; i > 0; i--)
        {
            fat = fat * i;
        }

        Console.WriteLine($"{fat}");
    }
}