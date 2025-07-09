using System; 

class URI {

    static void Main(string[] args)
    {

        string[] gameHours = Console.ReadLine().Split(' ');

        int firstHour = int.Parse(gameHours[0]);
        int lastHour = int.Parse(gameHours[1]);

        int result;

        if (firstHour < lastHour)
        {
            result = lastHour - firstHour;
        }
        else
        {
            result = 24 - firstHour + lastHour;
        }

        Console.WriteLine($"O JOGO DUROU {result} HORA(S)");
    }

}