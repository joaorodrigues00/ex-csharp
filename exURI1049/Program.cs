using System; 

class URI {

    static void Main(string[] args)
    {

        var word1 = Console.ReadLine();
        var word2 = Console.ReadLine();
        var word3 = Console.ReadLine();
        var result = "";

        if (word1 == "vertebrado")
        {
            if (word2 == "ave")
            {
                if (word3 == "carnivoro")
                {
                    result = "aguia";
                }
                else
                {
                    result = "pomba";
                }
            }
            else
            {
                if (word3 == "onivoro")
                {
                    result = "homem";
                }
                else
                {
                    result = "vaca";
                }
            }
        }
        else
        {
            if (word2 == "inseto")
            {
                if (word3 == "hematofago")
                {
                    result = "pulga";
                }
                else
                {
                    result = "lagarta";
                }
            }
            else
            {
                if (word3 == "hematofago")
                {
                    result = "sanguessuga";
                }
                else
                {
                    result = "minhoca";
                }
            }
        }

        Console.WriteLine($"{result}");
    }

}