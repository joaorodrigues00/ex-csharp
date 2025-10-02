using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        double A = double.Parse(values[0], CultureInfo.InvariantCulture);

        double B = double.Parse(values[1], CultureInfo.InvariantCulture);

        double C = double.Parse(values[2], CultureInfo.InvariantCulture);

        if (A + B > C && B + C > A && A + C > B)
        {
            double p = A + B + C;
            Console.WriteLine($"Perimetro = {p.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            double a = (A + B) * C / 2;
            Console.WriteLine($"Area = {a.ToString("F1", CultureInfo.InvariantCulture)}");
        }

    }

}