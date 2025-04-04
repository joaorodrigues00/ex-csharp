using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int resto;

        resto = (int)(value * 100 + 0.5);

        int div100 = resto / (100 * 100);
        int mod100 = resto % (100 * 100);

        int div50 = mod100 / (50 * 100);
        int mod50 = mod100 % (50 * 100);

        int div20 = mod50 / (20 * 100);
        int mod20 = mod50 % (20 * 100);

        int div10 = mod20 / (10 * 100);
        int mod10 = mod20 % (10 * 100);

        int div5 = mod10 / (5 * 100);
        int mod5 = mod10 % (5 * 100);

        int div2 = mod5 / (2 * 100);
        int mod2 = mod5 % (2 * 100);

        int div1 = mod2 / (1 * 100);
        int mod1 = mod2 % (1 *100);

        int div050 = mod1 / 50;
        int mod050 = mod1 % 50;

        int div025 = mod050 / 25;
        int mod025 = mod050 % 25;

        int div010 = mod025 / 10;
        int mod010 = mod025 % 10;

        int div005 = mod010 / 5;
        int mod005 = mod010 % 5;

        Console.WriteLine("NOTAS:");

        Console.WriteLine($"{div100} nota(s) de R$ 100.00");
        Console.WriteLine($"{div50} nota(s) de R$ 50.00");
        Console.WriteLine($"{div20} nota(s) de R$ 20.00");
        Console.WriteLine($"{div10} nota(s) de R$ 10.00");
        Console.WriteLine($"{div5} nota(s) de R$ 5.00");
        Console.WriteLine($"{div2} nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");

        Console.WriteLine($"{div1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{div050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{div025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{div010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{div005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{mod005} moeda(s) de R$ 0.01");
    }

}