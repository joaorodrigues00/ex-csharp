using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

class URI {

    static void Main(string[] args)
    {

        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int positiveNumberCounter = 0;
        double media1 = 0;
        double media2 = 0;
        double media3 = 0;
        double media4 = 0;
        double media5 = 0;
        double media6 = 0;
        double mediaFinal = 0;

        if (n1 > 0.0)
        {
            positiveNumberCounter++;
            media1 = n1;
        }

        if (n2 > 0.0)
        {
            positiveNumberCounter++;
            media2 = n2;
        }

        if (n3 > 0.0)
        {
            positiveNumberCounter++;
            media3 = n3;
        }

        if (n4 > 0.0)
        {
            positiveNumberCounter++;
            media4 = n4;
        }

        if (n5 > 0.0)
        {
            positiveNumberCounter++;
            media5 = n5;
        }

        if (n6 > 0.0)
        {
            positiveNumberCounter++;
            media6 = n6;
        }

        mediaFinal = (media1 + media2 + media3 + media4 + media5 + media6) / positiveNumberCounter;

        Console.WriteLine($"{positiveNumberCounter} valores positivos");
        Console.WriteLine(mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
    }

}