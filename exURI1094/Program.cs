using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int c = 0;
        int r = 0;
        int s = 0;

        for (int i = 0; i < n; i++)
        {

            string[] vet = Console.ReadLine().Split(' ');

            int value = int.Parse(vet[0]);
            string type = vet[1];

            switch (type)
            {
                case "C":
                    c = c + value;
                    break;

                case "R":
                    r = r + value;
                    break;

                case "S":
                    s = s + value;
                    break;
            }
        }

        int total = c + r + s;
        double percentageNumberFormattedC = (double)c / total * 100.0;
        double percentageNumberFormattedR = (double)r / total * 100.0;
        double percentageNumberFormattedS = (double)s / total * 100.0;

        Console.WriteLine($"Total: {total} cobaias");

        Console.WriteLine($"Total de coelhos: {c}");
        Console.WriteLine($"Total de ratos: {r}");
        Console.WriteLine($"Total de sapos: {s}");

        Console.WriteLine($"Percentual de coelhos: {percentageNumberFormattedC:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentageNumberFormattedR:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentageNumberFormattedS:F2} %");
    }
}

