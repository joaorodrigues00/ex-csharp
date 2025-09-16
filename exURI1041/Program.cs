using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        string[] coordenadas = Console.ReadLine().Split(' ');

        double coordenadaX = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
        double coordenadaY = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

        if (coordenadaX > 0.0 && coordenadaY > 0.0)
        {
            Console.WriteLine("Q1");
        } else if (coordenadaX < 0.0 && coordenadaY > 0.0)
        {
            Console.WriteLine("Q2");
        } else if (coordenadaX < 0.0 && coordenadaY < 0.0)
        {
            Console.WriteLine("Q3");
        } else if (coordenadaX > 0.0 && coordenadaY < 0.0)
        {
            Console.WriteLine("Q4");
        } else if (coordenadaX == 0.0 && coordenadaY == 0.0)
        {
            Console.WriteLine("Origem");
        } else if (coordenadaX == 0.0)
        {
            Console.WriteLine("Eixo Y");
        } else if (coordenadaY == 0.0)
        {
            Console.WriteLine("Eixo X");
        }

    }

}