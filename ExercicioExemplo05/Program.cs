using System; 

class Curso {

    static void Main(string[] args)
    {
        string[] nArray = Console.ReadLine().Split(' ');

        int count = 0;
        int itensSum = 0;

        while (int.Parse(nArray[count]) > 0)
        {
            itensSum = itensSum + int.Parse(nArray[count]);
            count++;
        }

        Console.WriteLine($"Soma final {itensSum}");
    }

}