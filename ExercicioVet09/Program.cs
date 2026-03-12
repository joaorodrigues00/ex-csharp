using System.Globalization;

class ExampleVet09
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] pCompra = new double[N];
        double[] pVenda = new double[N];
        double valorTotalCompra = 0.0;
        double valorTotalVenda = 0.0;
        int lucroAbaixo10 = 0;
        int lucroEntre10e20 = 0;
        int lucroAcimaDe20 = 0;
        double lucro = 0.0;

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            pCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
            pVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < N; i++)
        {
            valorTotalCompra += pCompra[i];
            valorTotalVenda += pVenda[i];

            lucro = pVenda[i] - pCompra[i]; 

            if (lucro / pCompra[i] * 100.0 < 10.0)
            {
                lucroAbaixo10++;
            } else if (lucro / pCompra[i] * 100.0 >= 10.0 && lucro / pCompra[i] * 100.0 <= 20.0)
            {
                lucroEntre10e20++;
            } else if(lucro / pCompra[i] * 100.0 > 20.0)
            {
                lucroAcimaDe20++;
            }
        }

        Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroAcimaDe20}");
        Console.WriteLine($"Valor total de compra: {valorTotalCompra:F2}");
        Console.WriteLine($"Valor total de venda: {valorTotalVenda:F2}");
        Console.WriteLine($"Lucro total {Math.Abs(valorTotalCompra - valorTotalVenda):F2}");
    }
}