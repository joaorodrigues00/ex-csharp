using System;

class ExampleVet06
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] names = new string[N];
        int[] ages = new int[N];
        int oldestPerson = 0;
        string oldestPersonName = "";

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            names[i] = s[0];
            ages[i] = int.Parse(s[1]);
        }

        for (int i = 0; i < N; i++)
        {
            if (ages[i] > oldestPerson)
            {
                oldestPerson = ages[i];
                oldestPersonName = names[i];
            }
        }

        Console.WriteLine($"Pessoa mais Velha: {oldestPersonName}");
    }
}