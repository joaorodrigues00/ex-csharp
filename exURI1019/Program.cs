using System; 

class URI {

    static void Main(string[] args) { 

        int timeInSeconds = int.Parse(Console.ReadLine());

        int hoursDiv = timeInSeconds / 3600;
        int hoursMod = timeInSeconds % 3600;

        int minutesDiv = hoursMod / 60;
        int minutesMod = hoursMod % 60;

        Console.WriteLine($"{hoursDiv}:{minutesDiv}:{minutesMod}");
    }

}