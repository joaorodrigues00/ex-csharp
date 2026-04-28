using System;

class URI
{
    public static void Main(string[] args)
    {
        string[] matSize = Console.ReadLine().Split(' ');

        int M = int.Parse(matSize[0]);
        int N = int.Parse(matSize[1]);

        int[,] matrice = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] matValues = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matrice[i, j] = int.Parse(matValues[j]);
            }
        }

        Console.WriteLine("VALORES NEGATIVOS:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrice[i, j] < 0)
                {
                    Console.WriteLine($"{matrice[i, j]}");
                }
            }
        }
    }
}