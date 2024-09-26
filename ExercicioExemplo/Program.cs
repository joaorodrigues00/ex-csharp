using System;
using System.Globalization;
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');

            string lastName = v[0];
            int age = int.Parse(v[1]);
            double height = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("====== Resultado ======");

            Console.WriteLine($"Nome: {name}");
            
            Console.WriteLine($"Quartos: {rooms}");

            Console.WriteLine($"Preço: {price.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Ultimo Nome: {lastName}");

            Console.WriteLine($"Idade: {age}");

            Console.WriteLine($"Altura: {height.ToString("", CultureInfo.InvariantCulture)}");
        }
    }
}