using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string seller = Console.ReadLine();

        double sellerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double monthSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double comission = monthSales * 0.15;

        double total = sellerSalary + comission;

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }

}