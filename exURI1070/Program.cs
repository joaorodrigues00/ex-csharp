using System; 

class URI {

    static void Main(string[] args)
    {

        int positiveNumber = int.Parse(Console.ReadLine());

        int oddCounter = 0;

        while (oddCounter < 6)
        {
            if (positiveNumber % 2 != 0)
            {
                oddCounter++;
                Console.WriteLine(positiveNumber);
            }

            positiveNumber++;
        }

    }

}