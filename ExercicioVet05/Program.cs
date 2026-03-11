class ExampleVet05
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] vet = new int[N];
        int media = 0;
        int evenNumbers = 0;

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            vet[i] = int.Parse(s[i]);

            if ((vet[i] & 1) == 0)
            {
                media += vet[i];
                evenNumbers++;
            }
        }

        Console.WriteLine($"{media / evenNumbers:F1}");
    }
}