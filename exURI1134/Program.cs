using System;

class URI
{
    static void Main(string[] args)
    {
        int code = int.Parse(Console.ReadLine());

        int alcohol = 0;
        int gasoline = 0;
        int diesel = 0;

        while (code != 4)
        {
            switch (code)
            {
                case 1:
                    alcohol++;
                    break;
                case 2:
                    gasoline++;
                    break;
                case 3:
                    diesel++;
                    break;
            }

            code = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");

        Console.WriteLine($"Alcool: {alcohol}");
        Console.WriteLine($"Gasolina: {gasoline}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}