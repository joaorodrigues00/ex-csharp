using System; 

class URI {

    static void Main(string[] args)
    {

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        int parCounter = 0;

        if (n1 % 2 == 0)
        {
            parCounter++;
        }

        if (n2 % 2 == 0)
        {
            parCounter++;
        }

        if (n3 % 2 == 0)
        {
            parCounter++;
        }

        if (n4 % 2 == 0)
        {
            parCounter++;
        }

        if (n5 % 2 == 0)
        {
            parCounter++;
        }

        Console.WriteLine($"{parCounter} valores pares");
    }

}