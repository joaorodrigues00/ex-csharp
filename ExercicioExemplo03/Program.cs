using System;
using System.Globalization;

class Program {
    public static void Main(string[] args) {

        double basicPlan = 50.00;

        int minutes = int.Parse(Console.ReadLine());

        if (minutes < 100) {
            Console.WriteLine($"Valor a pagar: R$ {basicPlan.ToString("F2", CultureInfo.InvariantCulture)}");
        } else {
            basicPlan += (minutes - 100) * 2.0;

            Console.WriteLine($"Valor a pagar: R$ {basicPlan.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}