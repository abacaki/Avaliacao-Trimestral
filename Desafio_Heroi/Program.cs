Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Um grande Dragão Vermelho 🐉 despertou e está ameaçando o reino! Você foi o aventureiro escolhido pela guilda para \navaliar se um " +
    "herói está apto a enfrentá-lo. Para começar, adicione os dados do herói:");

Console.WriteLine("\r\n\r\n1° Passo -> Digite o Nome do Herói:");
string Nomeh = Console.ReadLine();

Console.WriteLine($"\n2° Passo -> Escolha a Classe do Herói:" +
    $"\r\n\r\n1 - Mago \n2 - Clérigo \n3 - Guerreiro \n4 - Druida \n5 - Anão \n6 - Elfo \n7 - Troll");

string Classeh = Console.ReadLine();
string Classeh1 = "";

//Classes
if (Classeh == "1")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Mago 🧙 |");
    Classeh1 = "Mago 🧙";
}
else if (Classeh == "2")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Clérigo ⛪ |");
    Classeh1 = "Clérigo ⛪";
}
else if (Classeh == "3")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Guerreiro ⚔️ |");
    Classeh1 = "Guerreiro ⚔️";
}
else if (Classeh == "4")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Druida 🐻 |");
    Classeh1 = "Druida 🐻";
}
else if (Classeh == "5")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Anão 🌱 |");
    Classeh1 = "Anão 🌱";
}
else if (Classeh == "6")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Elfo 🧝 |");
    Classeh1 = "Elfo 🧝";
}
else if (Classeh == "7")
{
    Console.WriteLine($"\n|Herói {Nomeh} -> Classe: Troll 🧌 |");
    Classeh1 = "Troll 🧌";
}

Console.WriteLine("\n3° Passo -> Digite o Nível do Herói:");
int.TryParse(Console.ReadLine(), out int Nivel);
Console.WriteLine($"\n|Herói {Nomeh} -> Nível: {Nivel} |");

Console.WriteLine("\n4° Passo -> Digite os Pontos de Vida (HP) do Herói:");
double.TryParse(Console.ReadLine(), out double Vida);
Console.WriteLine($"\n|Herói {Nomeh} -> HP: {Vida} |");

Console.WriteLine("\n5° Passo -> Digite os Pontos de Magia (Mana) do Herói:");
int.TryParse(Console.ReadLine(), out int Mana);
Console.WriteLine($"\n|Herói {Nomeh} -> Mana: {Mana} |");

Console.WriteLine("\n6° Passo -> Digite a Quantidade de Ouro na Mochila do Herói:");
double.TryParse(Console.ReadLine(), out double Ouro);
Console.WriteLine($"\n|Herói {Nomeh} -> Ouro: {Ouro} |");

Console.WriteLine($"\nInformações Finais: " +
    $"\n|Herói {Nomeh} | Classe: {Classeh1} | Nível: {Nivel} | HP: {Vida} | Mana: {Mana} | Ouro: {Ouro} |");

//Guilda
Console.WriteLine("\nPara continuar o processo, avaliar entrada na guilda:");

if (Classeh1 != "Troll 🧌" && !(Nivel < 5))
{
    Console.WriteLine($"\n🧾Resultado da Guilda -> Herói {Nomeh}: ✅ACEITO! |" +
        $"\nO herói tem os requisitos necessários para participar da guilda!");
}

else if (Classeh1 == "Troll 🧌")
{
    Console.WriteLine($"\n| 🧾Resultado da Guilda -> Herói {Nomeh}: 🚫NEGADO! |" +
        $"\nO herói é um traidor!🐍 Ele não pode participar da guilda!");
    return;
}
else
{
    Console.WriteLine($"\n| 🧾Resultado da Guilda -> Herói {Nomeh}: 🚫NEGADO! |" +
        $"\nO herói não tem os requisitos necessários para participar da guilda! Seu nível é muito baixo 👎");
    return;
}

Console.WriteLine("\nContinuação do Processo Aprovada!👌 \r\n\r\n7° Passo - Calculo do Poder Base:");
double PoderBase = (Nivel * 10) + (Vida / 2) - 5;
Console.WriteLine($"\n|Herói {Nomeh} -> Poder Base {PoderBase} |");

if (PoderBase % 2 == 0)
{
    Console.WriteLine($"O herói recebeu um bônus de Ataque Crítico! 👊 Seu ataque agora será mais forte!");
}

//Ataque
Console.WriteLine($"Com todas as informações do herói {Nomeh}, chegou a hora de testar seu poder contra o Dragão Vermelho 🐉!");
bool PodeAtacar = false;


//Magia
if (Classeh1 == "Mago 🧙" || Classeh1 == "Druida 🐻" || Classeh1 == "Clérigo ⛪")
{
    if (Mana >= 30 && Nivel <= 100)
    {
        Console.WriteLine("\n✨ O herói tem mana suficiente para atacar! Seu cajado 🪄 está cheio de magia e pronto para dar um golpe no dragão! 💪 ");
        PodeAtacar = true;
    }
    else
    {
        Console.WriteLine("\n🚫 O herói tem mana insuficiente! O Cajado do herói falhou e ele só consegui lançar um tronco seco... 🪵");
    }
}

//Fisíco
else if (Classeh1 == "Guerreiro ⚔️" || Classeh1 == "Anão 🌱" || Classeh1 == "Elfo 🧝")
{
    if (Vida > 20 && PoderBase > 50)
    {
        Console.WriteLine($"\n🛡️ Ataque feito com sucesso! O herói conseguiu dar um golpe fatal no dragão ‼️");
        PodeAtacar = true;
    }
    else
    {
        Console.WriteLine($"\n😴 Ataque falhou! O herói está fraco 💔 demais para erguer a arma e atacar! Sua força não foi o bastante!");
    }
}

//Herói passou
if (PodeAtacar)
{
    Console.WriteLine($"\n🎯 DESTINO FINAL \nHerói {Nomeh} tem todos os requisitos para atacar o dragão e salvar o reino! 🏆");
}
else
{
    //Suborno
    if (Ouro > 1000 || Classeh1 == "Anão 🌱")
    {
        Console.WriteLine($"\nPor não poder lutar, o herói suborna 💰 o dragão e consegue fugir de virar churrasco!🍖");
    }
    else
    {
        Console.WriteLine($"\nPor não poder lutar, o herói tenta subornar 💰 o dragão, mas não consegue fugir e vira poeira!🔥");
    }
}


Console.WriteLine("\nFim da avaliação do herói!");
