using System.Runtime.CompilerServices;

class ExampleVet03
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        string[] sA = Console.ReadLine().Split(' ');
        string[] sB = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(sA[i]);
            B[i] = int.Parse(sB[i]);
        }

        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        foreach(int c in C)
        {
            Console.Write($"{c} ");
        }
    }
}