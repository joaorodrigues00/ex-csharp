using System;
using System.Globalization;

class Example
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] height = new double[N];
        int[] age = new int[N];
        double heightM = 0.0;
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            age[i] = int.Parse(s[1]);
            height[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < N; i++)
        {
            heightM += height[i];
        }

        for (int i = 0; i < N; i++)
        {
            if (age[i] < 16)
            {
                count++;
            }
        }

        Console.WriteLine($"{heightM / N:F2}");
        Console.WriteLine($"{(double) count / N * 100.0}");
    }
}