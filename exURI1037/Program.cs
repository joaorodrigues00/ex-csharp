using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        double intervalNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (intervalNumber >= 0.0 && intervalNumber <= 25.0)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (intervalNumber >= 25.0 && intervalNumber <= 50.0)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (intervalNumber >= 50.0 && intervalNumber <= 75.0)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (intervalNumber >= 75.0 && intervalNumber <= 100.0)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }

}