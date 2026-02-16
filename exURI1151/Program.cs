using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int atual = 0;
        int anterior = 1;

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                Console.WriteLine(atual);
            }
            else
            {
                Console.Write($"{atual} ");
            }

            int aux = anterior;
            anterior = atual;
            atual = aux + anterior;
        }
    }

}