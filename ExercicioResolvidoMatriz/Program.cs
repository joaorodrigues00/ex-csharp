using System;
using System.Diagnostics;

class URI
{
    public static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int M = int.Parse(vet[0]);
        int N = int.Parse(vet[1]);

        int[] finalVet = new int[M];

        for (int i = 0; i < M; i++)
        {
            vet = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                finalVet[i] += int.Parse(vet[j]);
            }
        }

        foreach(int fv in finalVet)
        {
            Console.WriteLine(fv);
        }

    }
}