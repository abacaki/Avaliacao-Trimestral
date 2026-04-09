//RPG - Yuri Saito Mena

Console.WriteLine("Digite o nome do herói:");
string nomeHeroi = Console.ReadLine();

int ataqueBase = 40;
int bonusArma = 10;
int ataqueTotal = ataqueBase + bonusArma;
double vidaInimigo = 150.5;
double dano = 50.5;
double vidaRestante = vidaInimigo - dano;
float moedas = 12.5f;
var moedasDobro = moedas * 2f;
long xpTotal = 1000000;
long mediaXP = xpTotal / 2;

Console.WriteLine($"{nomeHeroi} morava em uma pequena vila pacata, porém, devido as ameaças do Rei Demônio, " +
$"ele foi em uma missão para salvar o mundo! \n {nomeHeroi} tem um ataque base de {ataqueBase} e uma arma bônus que" +
$" lhe da mais {bonusArma} de ataque. Ele tem {ataqueTotal} de ataque total! \n Enquanto andava a caminho " +
$"do castelo do Rei Demônio {nomeHeroi} encontrou um inimigo. Escolha o que fazer:");


Console.WriteLine("\n 1 - Analisar vida \n 2 - Atacar ");

string escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine($"Vida total do inimigos é de: {vidaInimigo}. {nomeHeroi} decide atacar logo em seguida, causando {ataqueTotal} " +
     $"de dano! Vida restante do inimigo: {vidaRestante}.");

}

if (escolha == "2")
{
    Console.WriteLine($"{nomeHeroi} atacou causando {ataqueTotal} de dano! Vida restante do inimigo: {vidaRestante}");
}

Console.WriteLine($"\nAo atacar, o inimigo fugiu. {nomeHeroi} ganhou {moedas} moedas, mas, devido sua vitória, recebeu " +
$"o dobro de moedas, resultando em {moedasDobro} moedas no total. Além disso, {nomeHeroi} adquiriu {xpTotal} de" +
$" experiência, {mediaXP} sendo a média de seu nível. ");
Console.WriteLine($"\nApós andar por muitas horas e enfrentar vários inimigos {nomeHeroi} chegou ao castelo do Rei Demônio," +
$" o fim de sua jornada. Agora, ele está pronto para sua luta final!");


bool entendiMateria = true;