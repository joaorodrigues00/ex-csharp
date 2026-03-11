using System;

class ExampleVet02
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] vet = new int[N];
        int evenNumbersAmount = 0;

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            vet[i] = int.Parse(s[i]);

            if ((vet[i] & 1) == 0)
            {
                Console.Write($"{vet[i]} ");
                evenNumbersAmount++;
            }
        }
        Console.WriteLine();
        Console.Write(evenNumbersAmount);
    }
}