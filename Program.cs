Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Bem vindo a Arena de Pindorama! 🏟️");
Console.Write("\nDigite o nome do seu guerreiro: ");
string nomeGuerreiro = Console.ReadLine();

Console.WriteLine("\nEscolha seu inimigo: \r\n\r\n1 - Lobisomem 🐺 \n2 - Mula Sem Cabeça 🐴🔥");
string escolhaInimigo = Console.ReadLine();

FolkFighter warrior = new FolkFighter(nomeGuerreiro, 110, 20);
FolkFighter monster;

if (escolhaInimigo == "1")
{
    monster = new FolkFighter("Lobisomem", 100, 18);
}
else if (escolhaInimigo == "2")
{
    monster = new FolkFighter("Mula Sem Cabeça", 130, 22);
}
else
{
    Console.WriteLine("Opção inválida! Lobisomem escolhido.");
    monster = new FolkFighter("Lobisomem", 100, 18);
}

PindoramaArena arena = new PindoramaArena();

arena.RunBattle(warrior, monster);
arena.ShowLog();


Console.WriteLine("\nFim da batalha!");