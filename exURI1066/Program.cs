using System; 

class URI {

    static void Main(string[] args)
    {

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        int positiveCounter = 0;
        int negativeCounter = 0;
        int evenCounter = 0;
        int oddCounter = 0;

        if (n1 > 0)
        {
            positiveCounter++;
        }
        else if (n1 < 0)
        {
            negativeCounter++;
        }

        if (n1 % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }

        if (n2 > 0)
        {
            positiveCounter++;
        }
        else if (n2 < 0)
        {
            negativeCounter++;
        }

        if (n2 % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }

        if (n3 > 0)
        {
            positiveCounter++;
        }
        else if (n3 < 0)
        {
            negativeCounter++;
        }

        if (n3 % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }

        if (n4 > 0)
        {
            positiveCounter++;
        }
        else if (n4 < 0)
        {
            negativeCounter++;
        }

        if (n4 % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }

        if (n5 > 0)
        {
            positiveCounter++;
        }
        else if (n5 < 0)
        {
            negativeCounter++;
        }

        if (n5 % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }

        Console.WriteLine($"{evenCounter} valor(es) par(es)");
        Console.WriteLine($"{oddCounter} valor(es) impar(es)");
        Console.WriteLine($"{positiveCounter} valor(es) positivo(s)");
        Console.WriteLine($"{negativeCounter} valor(es) negativo(s)");
    }

}