using System;

public class URI
{
    static void Main(string[] args)
    {
        int PUM = int.Parse(Console.ReadLine());
        int value = 1;

        for (int i = 1; i <= PUM; i++)
        {
            Console.WriteLine($"{value} {value + 1} {value + 2} PUM");
            value += 4;
        }
    }
}