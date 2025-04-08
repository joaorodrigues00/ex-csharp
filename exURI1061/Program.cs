using System;

class URI
{

    static void Main(string[] args)
    {

        string[] iniDate = Console.ReadLine().Split(' ');
        string[] iniTime = Console.ReadLine().Split(':');

        int iniHour = int.Parse(iniTime[0]);

        int iniMin = int.Parse(iniTime[1]);

        int iniSec = int.Parse(iniTime[2]);

        int iniDay = int.Parse(iniDate[1]);
        int initialDayInSeconds = (iniDay - 1) * 24 * 60 * 60 
        + iniHour * 60 * 60 
        + iniMin * 60 + iniSec;

        string[] finDate = Console.ReadLine().Split(' ');
        string[] finTime = Console.ReadLine().Split(':');

        int finHour = int.Parse(finTime[0]);

        int finMin = int.Parse(finTime[1]);

        int finSec = int.Parse(finTime[2]);

        int finDay = int.Parse(finDate[1]);
        int finalDayInSeconds = (finDay - 1) * 24 * 60 * 60
        + finHour * 60 * 60
        + finMin * 60 + finSec;

        int diff = finalDayInSeconds - initialDayInSeconds;

        int dayDiff = diff / (24 * 60 * 60);
        int dayDiffMod = diff % (24 * 60 * 60);

        int hoursDiff = dayDiffMod / (60 * 60);
        int hoursDiffMod = dayDiffMod % (60 * 60);

        int minutesDiff = hoursDiffMod / 60;
        int minutesDiffMod = hoursDiffMod % 60;

        int secDiffMod = minutesDiffMod % 60;

        Console.WriteLine($"{dayDiff} dia(s)");

        Console.WriteLine($"{hoursDiff} hora(s)");

        Console.WriteLine($"{minutesDiff} minuto(s)");

        Console.WriteLine($"{secDiffMod} segundo(s)");
    }

}