using System;

class URI
{

    static void Main(string[] args)
    {

        int value = int.Parse(Console.ReadLine());

        int div100 = value / 100;
        int mod100 = value % 100;

        int div50 = mod100 / 50;
        int mod50 = mod100 % 50;

        int div20 = mod50 / 20;
        int mod20 = mod50 % 20;

        int div10 = mod20 / 10;
        int mod10 = mod20 % 10;

        int div5 = mod10 / 5;
        int mod5 = mod10 % 5;

        int div2 = mod5 / 2;
        int mod2 = mod5 % 2;

        int div1 = mod2 / 1;

        Console.WriteLine($"{value}");
        Console.WriteLine($"{div100} nota(s) de R$ 100,00");
        Console.WriteLine($"{div50} nota(s) de R$ 50,00");
        Console.WriteLine($"{div20} nota(s) de R$ 20,00");
        Console.WriteLine($"{div10} nota(s) de R$ 10,00");
        Console.WriteLine($"{div5} nota(s) de R$ 5,00");
        Console.WriteLine($"{div2} nota(s) de R$ 2,00");
        Console.WriteLine($"{div1} nota(s) de R$ 1,00");

    }

}