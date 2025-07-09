using System; 

class URI {

    static void Main(string[] args)
    {

        string[] multiples = Console.ReadLine().Split(' ');

        int n1 = int.Parse(multiples[0]);

        int n2 = int.Parse(multiples[1]);

        int div = n2 % n1;

        if (n1 > n2)
        {
            div = n1 % n2;
        }

        if (div == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}