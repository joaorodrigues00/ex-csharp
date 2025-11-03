using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string oddEven;
        string minusPlus;

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X > 0)
            {
                minusPlus = "POSITIVE";
            }
            else
            {
                minusPlus = "NEGATIVE";
            }
            
            if (X % 2 == 0)
            {
                oddEven = "EVEN";
            } else
            {
                oddEven = "ODD";
            }

            if (X == 0)
            {
                Console.WriteLine("NULL");
            } else
            {
                Console.WriteLine($"{oddEven} {minusPlus}");   
            }
        }
    }
}