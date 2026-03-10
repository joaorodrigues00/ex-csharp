using System;

class Example
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] vet1 = new int[N];

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            vet1[i] = int.Parse(s[i]);
            
            if (vet1[i] < 0)
            {
                Console.WriteLine($"{vet1[i]}");
            }
        }
    }
}