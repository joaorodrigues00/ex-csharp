using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] point1 = Console.ReadLine().Split(' ');

        string[] point2 = Console.ReadLine().Split(' ');

        double x1 = double.Parse(point1[0], CultureInfo.InvariantCulture);

        double y1 = double.Parse(point1[1], CultureInfo.InvariantCulture);

        double x2 = double.Parse(point2[0], CultureInfo.InvariantCulture);

        double y2 = double.Parse(point2[1], CultureInfo.InvariantCulture);

        double result = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

        Console.WriteLine($"{result.ToString("F4", CultureInfo.InvariantCulture)}");
    }

}