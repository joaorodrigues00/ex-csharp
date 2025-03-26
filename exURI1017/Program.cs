using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double time = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double velocity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double result = time * velocity / 12;

        Console.WriteLine($"{result.ToString("F3", CultureInfo.InvariantCulture)}");
    }

}