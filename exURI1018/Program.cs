using System;

class URI
{

    static void Main(string[] args)
    {

        int value = int.Parse(Console.ReadLine()); // 576;
        int originalValue = value;

        var div100Counter = 0;
        var div50Counter = 0;
        var div20Counter = 0;
        var div10Counter = 0;
        var div5Counter = 0;
        var div2Counter = 0;
        var div1Counter = 0;

        while (value > 0)
        {
            if (value >= 100)
            {
                div100Counter++;
                value -= 100;
            }
            else if (value >= 50)
            {
                div50Counter++;
                value -= 50;
            }
            else if (value >= 20)
            {
                div20Counter++;
                value -= 20;
            }
            else if (value >= 10)
            {
                div10Counter++;
                value -= 10;
            }
            else if (value >= 5)
            {
                div5Counter++;
                value -= 5;
            }
            else if (value >= 2)
            {
                div2Counter++;
                value -= 2;
            }
            else if (value >= 1)
            {
                div1Counter++;
                value -= 1;
            }
        }

        Console.WriteLine($"{originalValue}");
        Console.WriteLine($"{div100Counter} nota(s) de R$ 100,00");
        Console.WriteLine($"{div50Counter} nota(s) de R$ 50,00");
        Console.WriteLine($"{div20Counter} nota(s) de R$ 20,00");
        Console.WriteLine($"{div10Counter} nota(s) de R$ 10,00");
        Console.WriteLine($"{div5Counter} nota(s) de R$ 5,00");
        Console.WriteLine($"{div2Counter} nota(s) de R$ 2,00");
        Console.WriteLine($"{div1Counter} nota(s) de R$ 1,00");    }

}