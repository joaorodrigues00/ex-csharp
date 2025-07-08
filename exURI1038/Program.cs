using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {

        string[] item = Console.ReadLine().Split(' ');

        int itemCode = int.Parse(item[0]);
        int itemQuantity = int.Parse(item[1]);
        double itemPrice = 0;

        switch (itemCode)
        {
            case 1:
                itemPrice = itemQuantity * 4.00;
                break;
            case 2:
                itemPrice = itemQuantity * 4.50;
                break;
            case 3:
                itemPrice = itemQuantity * 5.00;
                break;
            case 4:
                itemPrice = itemQuantity * 2.00;
                break;
            case 5:
                itemPrice = itemQuantity * 1.50;
                break;
        }

        Console.WriteLine($"Total: R$ {itemPrice.ToString("F2", CultureInfo.InvariantCulture)}");
    }

}