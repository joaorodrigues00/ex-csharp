using System;

class URI
{
    static void Main(string[] args)
    {
        string[] matriceSize = Console.ReadLine().Split(' ');
        string[] vetA;
        string[] vetB;
        int M = int.Parse(matriceSize[0]);
        int N = int.Parse(matriceSize[1]);

        int[,] A = new int[M, N];
        int[,] B = new int[M, N];

        int[,] C = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            vetA = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                A[i,j] = int.Parse(vetA[j]);
            }
        }

        for (int i = 0; i < M; i++)
        {
            vetB = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                B[i,j] = int.Parse(vetB[j]);
            }
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                C[i,j] += A[i,j] + B[i,j];

                if (j < N - 1)
                {
                    Console.Write($"{C[i,j]} ");
                } else
                {
                    Console.WriteLine($"{C[i,j]}");
                }
            }
        }
    }
}