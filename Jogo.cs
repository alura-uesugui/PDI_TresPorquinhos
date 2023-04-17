using System;
class Jogo
{
    public static string[] nomes = { "Rodolfo", "Robert", "Carlinhos", "Felizberto", "João", "Chuvinista", "Felizardo", "Miss Pig", "Astolfo", "Abigail", "Clarissa", "Felícia", "Lili", "Ofélia", "Charlotte", "Arlindo", "Maga", "Tatá", "Doug", "Mimi" };
    public static string[] materiais = { "tijolos", "madeira", "palha", "barro", "folhas de samambaias", "pedras", "bambu", "vidro", "papel machê", "papelão" };
    public static int sortear(int nmax = 4)
    {
        Random rnd = new Random();
        int numero = rnd.Next(1, nmax);
        return numero;
    }

    public static string[] embaralhar(string[] array)
    {
        Random rnd = new Random();
        array = array.OrderBy(x => rnd.Next()).ToArray();
        return array;
    }

    public void iniciarJogo(Casa casa1, Casa casa2, Casa casa3, string[] nomes, string[] materiais)
    {
        // Emabaralhar nomes para não aparecerem na mesma ordem das casas
        nomes = embaralhar(nomes);
        materiais = embaralhar(materiais);

        Console.WriteLine($"{nomes[0]}, {nomes[1]} e {nomes[2]} construíram três casas,");
        Console.WriteLine($"cada qual com um material diferente:");
        Console.WriteLine($"{materiais[0]}, {materiais[1]} e {materiais[2]}.");
        Console.WriteLine();

        // Três grupos de frases possíveis
        var numero = sortear();
        switch(numero)
        {
            case 1:
                Console.WriteLine($"A casa n°{casa2.Posicao} é de {casa2.Material}.");
                Console.WriteLine($"{casa1.Morador} mora na casa de {casa1.Material}.");
                Console.WriteLine($"{casa3.Morador} mora na casa n°{casa3.Posicao}.");
                break;
            case 2:
                Console.WriteLine($"{casa1.Morador} mora na casa n°{casa1.Posicao}.");
                Console.WriteLine($"A casa n°{casa3.Posicao} é de {casa3.Material}.");
                Console.WriteLine($"{casa2.Morador} mora na casa de {casa2.Material}.");
                break;
            case 3:
                Console.WriteLine($"{casa3.Morador} mora na casa de {casa3.Material}.");
                Console.WriteLine($"{casa2.Morador} mora na casa n°{casa2.Posicao}.");
                Console.WriteLine($"A casa n°{casa1.Posicao} é de {casa1.Material}.");
                break;
            default:
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Quem mora em cada casa?");
        Console.WriteLine("Qual o material de cada construção?");
        Console.WriteLine();
        Console.WriteLine("      .        .        .     \n" + 
                          "     / \\      / \\      / \\ \n" +
                          "    /___\\    /___\\    /___\\\n" +
                          " ___| 1 |____| 2 |____| 3 |___ "
                         );
        Console.WriteLine();
        Console.WriteLine("(Pressione Enter para conferir a resposta.)");
        Console.ReadLine();
    }
}