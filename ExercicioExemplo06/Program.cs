using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class URI {

    static void Main(string[] args) {

        double age = double.Parse(Console.ReadLine());
        double ageMedia = 0;
        int count = 0;

        if (age < 0)
        {
            Console.WriteLine("impossivel calcular");
        } else
        {
            while (age > 0)
            {
                ageMedia = ageMedia + age;
                count++;

                age = int.Parse(Console.ReadLine());
            }

            double result = ageMedia / count;

            Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));   
        }
    }

}