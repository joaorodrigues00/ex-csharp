using System;

class Program {
    public static void Main(string[] args) {

        int weekDayNumber = int.Parse(Console.ReadLine());
        string weekDay;

        switch(weekDayNumber) {
            case 1:
                weekDay = "Domingo";
            break;

            case 2:
                weekDay = "Segunda-Feira";
            break;

            case 3:
                weekDay = "Terça-Feira";
            break;

            case 4:
                weekDay = "Quarta-Feira";
            break;

            case 5:
                weekDay = "Quinta-Feira";
            break;

            case 6:
                weekDay = "Sexta-Feira";
            break;

            case 7:
                weekDay = "Sábado";
            break;

            default:
                weekDay = "Valor Invalido";
            break;
        }

        Console.WriteLine($"Dia da Semana: {weekDay}");
    }
}