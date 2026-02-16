using System; 

class URI {

    static void Main(string[] args) { 

        double s = 0.0;
        double j = 1.0;
        for (int i = 1; i <= 39; i += 2)
        {
            s  = s + i / j;
            j = j * 2.0;
        }

        Console.WriteLine($"{s.ToString("F2")}");

    }

}