using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int positiveCounter = 0;

        if (n1 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        if (n2 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        if (n3 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        if (n4 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        if (n5 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        if (n6 > 0.0)
        {
            positiveCounter = positiveCounter + 1;
        }

        Console.WriteLine($"{positiveCounter} valores positivos");

    }
}