using System;
using System.Globalization;
using System.Runtime.InteropServices;
class URI
{
    static void Main(string[] args)
    {
        int option = 1;

        while (option != 2)
        {
            if (option == 1)
            {
                double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n1 < 0 || n1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n2 < 0 || n2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double result = (n1 + n2) / 2;
                Console.WriteLine($"media = {result.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            option = int.Parse(Console.ReadLine());
        }
    }
}

// Codigo do Nelio
/*using System;
using System.Globalization;

namespace uri118
{
    class Program
    {
        static void Main(string[] args)
        {
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}*/

