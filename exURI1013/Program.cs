using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        int A = int.Parse(values[0]);
        int B = int.Parse(values[1]);
        int C = int.Parse(values[2]);

        int maiorAb = (A + B + Math.Abs(A - B)) / 2;

        if (maiorAb > C)
        {
            Console.WriteLine($"{maiorAb} eh o maior");
        }
        else
        {
            Console.WriteLine($"{C} eh o maior");
        }
    }

}