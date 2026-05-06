using System;

public class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[,] matrice = new int[N, N];
        string[] vet;
        int greater = 0;

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
            greater = matrice[i, 0];
            for (int j = 0; j < N; j++)
            {
                if (matrice[i, j] > greater)
                {
                    greater = matrice[i, j];
                }
            }

            Console.WriteLine($"{greater}");
        }
    }
}