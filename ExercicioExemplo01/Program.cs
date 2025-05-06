using System.Globalization;

namespace ExercicioExemplo
{
    public class Program {
        public static void Main(string[] args)
        {
            double NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = NotaA + NotaB;

            Console.WriteLine($"NOTA FINAL = {resultado.ToString("F1", CultureInfo.InvariantCulture)}");

            if (resultado < 60.0) {    
                Console.WriteLine("REPROVADO");
            } 
        }
    }
}