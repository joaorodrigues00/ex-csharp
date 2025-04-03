using System;

class URI
{

    static void Main(string[] args)
    {

        int value = int.Parse(Console.ReadLine());

        int yearMod = value % 365;
        int yearDiv = value / 365;

        int monthMod = yearMod % 30;
        int monthDiv = yearMod / 30;

        int daysMod = monthMod;

        Console.WriteLine($"{yearDiv} ano(s)");
        Console.WriteLine($"{monthDiv} mes(es)");
        Console.WriteLine($"{daysMod} dia(s)");
    }

}