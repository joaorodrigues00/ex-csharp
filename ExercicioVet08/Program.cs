using System.Globalization;

class ExampleVet08
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        double[] heights = new double[N];
        char[] sex = new char[N];
        double averageWomanHeight = 0.0;
        double shorterHeight = 0.0;
        double greaterHeight = 0.0;
        int manCounter = 0;
        int womanCounter = 0;

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            heights[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
            sex[i] = char.Parse(s[1]);
        }

        shorterHeight = heights[0];

        for (int i = 0; i < N; i++)
        {
            if (sex[i] == 'F')
            {
                averageWomanHeight += heights[i];
                womanCounter++;
            } else
            {
                manCounter++;
            }

            if (heights[i] > greaterHeight)
            {
                greaterHeight = heights[i];
            }

            if (heights[i] < shorterHeight)
            {
                shorterHeight = heights[i];
            }
        }

        Console.WriteLine($"Menor Altura = {shorterHeight:F2}");
        Console.WriteLine($"Maior Altura = {greaterHeight:F2}");
        Console.WriteLine($"Media das alturas das mulheres = {(double) averageWomanHeight / womanCounter:F2}");
        Console.WriteLine($"Numero de homens = {manCounter}");
    }
}