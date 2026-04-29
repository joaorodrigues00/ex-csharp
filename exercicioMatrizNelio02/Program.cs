using System;

class URI
{
    static void Main(string[] args)
    {
        int matriceSize = int.Parse(Console.ReadLine());

        int[,] matrice = new int[matriceSize, matriceSize];
        int[] finalVet = new int[matriceSize];

        for (int i = 0; i < matriceSize; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            for (int j = 0; j < matriceSize; j++)
            {
                matrice[i, j] = int.Parse(vet[j]);
            }
        }

        for (int i = 0; i < matriceSize; i++)
        {
            for (int j = 0; j < matriceSize; j++)
            {
                finalVet[i] += matrice[i, j];
            }
        }

        foreach(int m in finalVet)
        {
            Console.WriteLine($"{m}");
        }
    }
}