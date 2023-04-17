
Jogo jogo = new Jogo();
var nomes = Jogo.embaralhar(Jogo.nomes).Take(3).ToArray();
var materiais = Jogo.embaralhar(Jogo.materiais).Take(3).ToArray();

// Instanciar casas
Casa casa1 = new Casa(nomes[0], materiais[0]);
Casa casa2 = new Casa(nomes[1], materiais[1]);
Casa casa3 = new Casa(nomes[2], materiais[2]);

// Iniciar jogo
jogo.iniciarJogo(casa1, casa2, casa3, nomes, materiais);

// Mostrar resposta
Console.WriteLine();
Console.WriteLine("RESPOSTA:");
Console.WriteLine("=========");
Console.WriteLine($"{casa1.Morador} mora na casa n° {casa1.Posicao}, feita de {casa1.Material}.");
Console.WriteLine($"{casa2.Morador} mora na casa n° {casa2.Posicao }, feita de {casa2.Material}.");
Console.WriteLine($"{casa3.Morador} mora na casa n° {casa3.Posicao}, feita de {casa3.Material}.");

// Fechar programa
Console.WriteLine();
Console.WriteLine("(Pressione Enter para fechar)");
Console.ReadLine();
