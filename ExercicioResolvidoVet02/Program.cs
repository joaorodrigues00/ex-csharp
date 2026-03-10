using System;

class Example
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] vet = new double[N];
        double soma = 0.0;

        string[] s = Console.ReadLine().Split(' ');
        Console.Clear();

        for (int i = 0; i < N; i++)
        {
            vet[i] = double.Parse(s[i]);
            soma += vet[i];

            if (i + 1 == N)
            {
                Console.WriteLine($"{vet[i]:F1}");
            } else
            {
                Console.Write($"{vet[i]:F1} ");   
            }
        }

        Console.WriteLine($"{soma:F2}");
        Console.WriteLine($"{soma / N:F2}");
    }
}