using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double ages = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int ageCounter = 0;
        double ageResults = 0;

        while (ages > 0)
        {
            ageResults += ages;
            ageCounter++;
            ages = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double avgAge = ageResults / ageCounter;
        Console.WriteLine($"{avgAge.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}