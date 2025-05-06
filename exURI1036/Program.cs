using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');

        double a, b, c, delta, r1, r2;

        a = double.Parse(values[0], CultureInfo.InvariantCulture);
        b = double.Parse(values[1], CultureInfo.InvariantCulture);
        c = double.Parse(values[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(b, 2.0) - 4 * a * c;

        if (a == 0 || delta < 0.0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}