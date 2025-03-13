using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var consumoMedio = x / y;

        Console.WriteLine($"{consumoMedio.ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }

}