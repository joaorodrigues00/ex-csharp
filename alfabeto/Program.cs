using System;

class Alfabeto
{
    static void Main(string[] args)
    {

        string[] alfabeto = [
            "A", "B", "C", "D", "E", "F",
            "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X",
            "Y", "Z"
        ];

        int letra = int.Parse(Console.ReadLine());
        int counter = 0;

        while (letra >= counter)
        {
            Console.WriteLine($"{alfabeto[counter]}");
            counter++;
        }
    }
}