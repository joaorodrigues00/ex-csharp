using System;
class URI
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int counter = 0;
        int lastNumber = 0;

        while (x != 0)
        {
            while (counter < 5)
            {
                if (x % 2 == 0)
                {
                    firstNumber = x;

                    x = x + 2;

                    lastNumber = lastNumber + firstNumber;
                }
                else
                {
                    firstNumber = x + 1;

                    x = x + 2;

                    lastNumber = lastNumber + firstNumber;
                }

                counter++;
            }

            Console.WriteLine($"{lastNumber}");

            counter = 0;
            lastNumber = 0;

            x = int.Parse(Console.ReadLine());
        }
    }
}

// Codigo do Nelio
/* using System;

namespace uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                // se for impar, some mais 1
                if (x % 2 != 0)
                {
                    x = x + 1;
                }

                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}*/