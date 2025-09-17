using System; 

class URI {

    static void Main(string[] args)
    {

        string[] tempo = Console.ReadLine().Split(' ');

        int horaIni = int.Parse(tempo[0]);

        int minIni = int.Parse(tempo[1]);

        int horaFin = int.Parse(tempo[2]);

        int minFin = int.Parse(tempo[3]);

        int instanteInicial = horaIni * 60 + minIni;
        int instanteFinal = horaFin * 60 + minFin;

        int duracao;
        if (instanteInicial < instanteFinal)
        {
            duracao = instanteFinal - instanteInicial;
        }
        else
        {
            duracao = 24 * 60 - instanteInicial + instanteFinal;
        }

        int duracaoHoras = duracao / 60;
        int duracaoMinutos = duracao % 60;

        Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

    }

}