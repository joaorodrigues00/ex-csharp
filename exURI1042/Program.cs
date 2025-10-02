using System; 

class URI {

    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');

        int n1 = int.Parse(numbers[0]);
        int n2 = int.Parse(numbers[1]);
        int n3 = int.Parse(numbers[2]);

        int mn1;
        int mn2;
        int mn3;

        if (n1 < n2 && n1 < n3)
        {
            mn1 = n1;

            if (n2 < n3)
            {
                mn2 = n2;
                mn3 = n3;
            }
            else
            {
                mn2 = n3;
                mn3 = n2;
            }
        }
        else if (n2 < n1 && n2 < n3)
        {
            mn1 = n2;

            if (n1 < n3)
            {
                mn2 = n1;
                mn3 = n3;
            }
            else
            {
                mn2 = n3;
                mn3 = n1;
            }
        }
        else
        {
            mn1 = n3;

            if (n1 < n2)
            {
                mn2 = n1;
                mn3 = n2;
            }
            else
            {
                mn2 = n2;
                mn3 = n1;
            }
        }

        Console.WriteLine($"{mn1}");
        Console.WriteLine($"{mn2}");
        Console.WriteLine($"{mn3}");
        Console.WriteLine("");
        Console.WriteLine($"{n1}");
        Console.WriteLine($"{n2}");
        Console.WriteLine($"{n3}");
    }

}