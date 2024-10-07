using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int employeeNumber = int.Parse(Console.ReadLine());
        int workedHours = int.Parse(Console.ReadLine());

        double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double employeeSalary = workedHours * valueHour;

        Console.WriteLine($"NUMBER = {employeeNumber}");
        Console.WriteLine($"SALARY = U$ {employeeSalary.ToString("F2", CultureInfo.InvariantCulture)}");
    }

}