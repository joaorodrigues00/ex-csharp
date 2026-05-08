using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[,] matrice = new int[N, N];
        string[] vet;
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            vet = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matrice[i, j] = int.Parse(vet[j]);
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i < j)
                {
                    sum += matrice[i, j];
                }
            }
        }
        Console.WriteLine($"{sum}");
    }
}