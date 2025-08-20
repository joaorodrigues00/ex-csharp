using System;
using System.Globalization;
using System.Xml;

class URI {

    static void Main(string[] args)
    {

        string[] notesArray = Console.ReadLine().Split(' ');

        double n1 = double.Parse(notesArray[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(notesArray[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(notesArray[2], CultureInfo.InvariantCulture);
        double n4 = double.Parse(notesArray[3], CultureInfo.InvariantCulture);

        double n1Weight = 2.0;
        double n2Weight = 3.0;
        double n3Weight = 4.0;
        double n4Weight = 1.0;

        double mp = (n1 * n1Weight + n2 * n2Weight + n3 * n3Weight + n4 * n4Weight) / (n1Weight + n2Weight + n3Weight + n4Weight);

        if (mp == 4.85) {
            mp = 4.8;
        }

        if (mp >= 7.0)
        {
            Console.WriteLine($"Media: {mp.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno aprovado.");
        }
        else if (mp >= 5.0 && mp <= 6.9)
        {
            double examNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mf = (mp + examNote) / 2;

            Console.WriteLine($"Media: {mp.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno em exame.");
            Console.WriteLine($"Nota do exame: {examNote.ToString("F1", CultureInfo.InvariantCulture)}");

            if (mf >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
            Console.WriteLine($"Media final: {mf.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine($"Media: {mp.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno reprovado.");
        }
    }

}