using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double note = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int validNote = 0;
        double result = 0;

        while (validNote < 2)
        {
            if (note < 0.0 || note > 10.0)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                result = result + note;
                validNote++;
            }

            if (validNote < 2)
            {
                note = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        double finalResult = result / 2.0;

        Console.WriteLine($"media = {finalResult.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}