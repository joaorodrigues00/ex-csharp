using System.Globalization;

class ExampleVet04
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] numbers = new double[N];
        double media = 0.0;

        string[] s = Console.ReadLine().Split(' ');

        for(int i = 0; i < N; i++)
        {
            numbers[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            media += numbers[i];
        }

        Console.WriteLine($"{(double) media / N:F3}");

        for (int i = 0; i < N; i++)
        {
            if (numbers[i] < ((double) media / N))
            {
                Console.WriteLine($"{numbers[i]:F1}");
            }
        }
    }
}