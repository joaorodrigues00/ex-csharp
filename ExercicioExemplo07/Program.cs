using System;
using System.Globalization;

class Example
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float[] vet;
        vet = new float[N];

        for (int i = 0; i < N; i++)
        {
            float Nd = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vet[i] = Nd;
        }

        for(int j = 0; j < vet.Length; j++)
        {
            Console.WriteLine($"{vet[j]:F1}");
        }
    }
}