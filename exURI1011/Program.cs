using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        var pi = 3.14159;

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var formula = (4.0/3) * pi * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {formula.ToString("F3", CultureInfo.InvariantCulture)}");

    }

}