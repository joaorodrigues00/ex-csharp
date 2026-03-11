class ExampleVet01
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] numbers = new double[N];
        double biggestNumber = 0.0, vetPosition = 0.0;

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            numbers[i] = double.Parse(s[i]);
        }

        for (int i = 0; i < N; i++)
        {
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
                vetPosition = i;
            }
        }

        Console.WriteLine($"{biggestNumber}");
        Console.WriteLine($"{vetPosition}");
    }
}