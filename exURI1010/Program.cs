using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] product1 = Console.ReadLine().Split(' ');

        string[] product2 = Console.ReadLine().Split(' ');

        int p1Code = int.Parse(product1[0]);

        int p1PieceQuantity = int.Parse(product1[1]);

        double p1PieceValue = double.Parse(product1[2], CultureInfo.InvariantCulture);

        int p2Code = int.Parse(product2[0]);

        int p2PieceQuantity = int.Parse(product2[1]);

        double p2PieceValue = double.Parse(product2[2], CultureInfo.InvariantCulture);

        double total = p1PieceQuantity * p1PieceValue + p2PieceQuantity * p2PieceValue;

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}