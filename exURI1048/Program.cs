using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int percentageAdjustment;
        double readjustmentValue;

        double readjustmentSalary;

        if (salary >= 0 && salary <= 400.00)
        {
            percentageAdjustment = 15;
            readjustmentValue = salary * 0.15;

            readjustmentSalary = salary + readjustmentValue;
        }
        else if (salary > 400.00 && salary <= 800.00)
        {
            percentageAdjustment = 12;
            readjustmentValue = salary * 0.12;

            readjustmentSalary = salary + readjustmentValue;
        }
        else if (salary > 800.00 && salary <= 1200.00)
        {
            percentageAdjustment = 10;
            readjustmentValue = salary * 0.10;

            readjustmentSalary = salary + readjustmentValue;
        }
        else if (salary > 1200 && salary <= 2000)
        {
            percentageAdjustment = 7;
            readjustmentValue = salary * 0.07;

            readjustmentSalary = salary + readjustmentValue;
        }
        else
        {
            percentageAdjustment = 4;
            readjustmentValue = salary * 0.04;

            readjustmentSalary = salary + readjustmentValue;
        }

        Console.WriteLine($"Novo salario: {readjustmentSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {readjustmentValue.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {percentageAdjustment} %");

    }

}