using System; 

class URI {

    static void Main(string[] args) { 

        int greaterN = int.Parse(Console.ReadLine());
        int positionN = 1;

        for (int i = 2; i <= 100; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > greaterN)
            {
                greaterN = n;
                positionN = i;
            }
        }

        Console.WriteLine($"{greaterN}");
        Console.WriteLine($"{positionN}");

    }

}