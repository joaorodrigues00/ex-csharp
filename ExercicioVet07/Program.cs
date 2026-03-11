using System.Globalization;

class ExampleVet07
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        double[] firstSem = new double[N];
        double[] secondSem = new double[N];
        double[] media = new double[N];
        string[] names = new string[N];

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            names[i] = s[0];
            firstSem[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
            secondSem[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            media[i] = (firstSem[i] + secondSem[i]) / 2.0;
        }

        Console.WriteLine("Alunos aprovados: ");

        for (int i = 0; i < N; i++)
        {
            if (media[i] >= 6.0)
            {
                Console.WriteLine($"{names[i]}");
            }
        }

    }
}