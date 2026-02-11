using System;

public class URI
{
    static void Main(string[] args)
    {
        int operationAmount;
        double dividendo, divisor, result;

        operationAmount = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < operationAmount; i ++)
        {
            string[] vet = Console.ReadLine().Split(' ');

            dividendo = double.Parse(vet[0]);
            divisor = double.Parse(vet[1]);

            result = dividendo / divisor;

            if (divisor == 0)
            {
                Console.WriteLine("divisao impossivel");
            } else
            {
                Console.WriteLine(result.ToString("F1"));
            }
        }
    }
}