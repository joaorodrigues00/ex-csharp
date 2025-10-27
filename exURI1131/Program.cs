using System;

class URI
{
    static void Main(string[] args)
    {
        int grenalOption = 1;
        int grenalQuantity = 0;
        int grenalDrawQuantity = 0;
        int interWin = 0;
        int gremioWin = 0;

        while (grenalOption != 2)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int interGoals = int.Parse(vet[0]);
            int gremioGoals = int.Parse(vet[1]);

            if (interGoals == gremioGoals)
            {
                grenalDrawQuantity++;
            }

            if (interGoals > gremioGoals)
            {
                interWin++;
            }
            else
            {
                gremioWin++;
            }

            grenalQuantity++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            grenalOption = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"{grenalQuantity} grenais");
        Console.WriteLine($"Inter:{interWin}");
        Console.WriteLine($"Gremio:{gremioWin}");
        Console.WriteLine($"Empates:{grenalDrawQuantity}");

        if (interWin == gremioWin)
        {
            Console.WriteLine("Nao houve vencedor");
        } else if (interWin > gremioWin)
        {
            Console.WriteLine("Inter venceu mais");
        } else
        {
            Console.WriteLine("Gremio venceu mais");
        }
    }
}