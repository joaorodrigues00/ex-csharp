using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        double A = double.Parse(values[0], CultureInfo.InvariantCulture);

        double B = double.Parse(values[1], CultureInfo.InvariantCulture);

        double C = double.Parse(values[2], CultureInfo.InvariantCulture);

        double triangulo = A * C / 2;

        double circulo = 3.14159 * Math.Pow(C, 2);

        double trapezio = (A + B) * C / 2;

        double quadrado = B * B;

        double retangulo = A * B;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }

}