//Hackaton - Yuri Saito Mena

Console.OutputEncoding = System.Text.Encoding.UTF8;

//Declaração de Variável
int escolhajogador = 0; int escolhapalhaco = 0; int pontuacao = 0; int pontuacaopalhaco = 0;

Console.WriteLine("Você é um aventureiro que sentia muita vontade de explorar o mundo e virar o melhor cavaleiro da história, porém, em meio " +
  "a sua viagem para a capital, você encontra um circo diferente de qualquer coisa que já viu." +
  "\nCurioso, você decide entrar nesse lugar tão interessante, mas se assusta quando encontra um palhaço de aparência um pouco sombria," +
  " de olhos fechados e roupas levemente sujas. Ele pergunta:\n“Você parece diferente de todos que passaram aqui… Vamos jogar alguns jogos? ”" +
  "\r\n\r\nCético, você decide recusar educadamente, porém o palhaço parece irritado, finalmente abrindo seus olhos para revelar um mar de " +
  "escuridão em suas íris e pupilas, adicionando mais uma coisa estranha para seu visual intimidador." +
  "\n“Vou perguntar novamente… Vamos jogar alguns jogos?”\r\n\r\nCom medo, você aceita, se sentindo pressionado por aqueles olhos e atmosfera " +
  "pesada que lhe cercam.\r\n“Boa escolha… Começaremos por um tradicional jogo de adivinha. " +
  "\r\n\r\nEle esconde as mãos atrás das costas, seu sorriso anormal aumentando ainda mais ao ver seu olhar assustado." +
  "\n“Estou pensando em um número de um a cinco. Se o seu coração bater no mesmo ritmo que o meu pensamento, você ganha.”" +
  "\r\n\r\n Escolha um número de 1 a 5:");

//Primeiro jogo
int.TryParse(Console.ReadLine(), out escolhajogador);
Console.WriteLine($"O número que você escolheu foi: {escolhajogador}.");
Random escolha = new Random();
escolhapalhaco = escolha.Next(1, 6);

if (escolhajogador == escolhapalhaco) //Ganha
{
    pontuacao += 1;
    Console.WriteLine($"Vitória! Você ganhou! \nA escolha do palhaço foi {escolhapalhaco} e sua foi {escolhajogador}.\r\n\r\nPontuação:\nVocê: {pontuacao} " +
      $"\nPalhaço: {pontuacaopalhaco}. \r\n\r\nO palhaço começa a " +
      $"rir, parecendo estar realmente se divertindo com a brincadeira." +
      $"\r\n“Finalmente um oponente digno! Mas não ache que acabou... ainda tenho mais jogos para você antes de ir embora! ” ");
}

else //Perde
{
    pontuacaopalhaco += 1;
    Console.WriteLine($"Derrota... Você perdeu!  \nA escolha do palhaço foi {escolhapalhaco} e sua foi {escolhajogador}. " +
      $"\r\n\r\nPontuação:\nVocê: {pontuacao} \nPalhaço: {pontuacaopalhaco}. \r\n\r\nO palhaço faz uma " +
      $"expressão de decepção; aparentemente, você não era tão incrível quanto ele imaginava." +
      $"\r\n“Que desgosto… achei que você fosse mais divertido do que isso. Mas tudo bem, vou te perdoar desta vez, afinal temos muitos mais" +
      $" jogos pela frente! ” ");
}

//Segundo jogo
Console.WriteLine("\r\n\r\n“Agora, para o segundo jogo, vamos jogar um dos meus jogos favoritos: cara ou coroa! Vou deixar você escolher primeiro.”" +
  "\r\n1 -> Cara\r\n2 -> Coroa\r\n");

Random moeda = new Random();

int resultadomoeda = moeda.Next(1, 3);
int escolhajogador1;

int.TryParse(Console.ReadLine(), out escolhajogador1);
Console.WriteLine($"Sua escolha foi: {escolhajogador1} ");

int escolhapalhaco1 = escolhajogador1 - 1;

Console.WriteLine("\nA moeda gira no ar e cai no chão com um som metálico... ");

if (escolhapalhaco1 == resultadomoeda) //Ganha
{
    pontuacao += 1;
    Console.WriteLine($"\n Vitória! Dessa vez a sorte agiu ao seu favor! \r\n\r\nPontuação: \nVocê -> {pontuacao}\nPalhaço -> {pontuacaopalhaco}. " +
      $"\r\n\r\nO palhaço o encara com surpresa, mas logo sorri com animação. \n“Bom trabalho, caro aventureiro! Vamos para o próximo" +
      $" jogo logo, quero ver o quanto mais você pode me surpreende!”");

}
else //Perde
{
    pontuacaopalhaco += 1;
    Console.WriteLine($"\n Derrota! Dessa vez a sorte não foi ao seu favor! \r\n\r\nPontuação \nVocê -> {pontuacao}\nPalhaço -> {pontuacaopalhaco}.\r\n\r\nO palhaço ri " +
      "descontroladamente, parecendo mais feliz do que nunca com sua derrota.");
    Console.WriteLine("\n“Que peninha... Mas não desanime, vamos para o próximo jogo! Quero o ver o quanto mais você aguenta!”");
}

//Terceiro Jogo
Console.WriteLine("\r\n\r\n“Pronto para o terceiro jogo? Por que eu estou!” \nEle pega um baralho , o embaralhando enquanto não tira os olhos de você." +
  " Vamos jogar um que eu mesmo criei, o Jogo do Abismo! Eu vou tirar duas cartas e você tem que tentar adivinhar se a próxima terá um número" +
  "maior ou menor do que as duas que já tirei!");

Random numeros = new Random();
int numero1 = numeros.Next(1, 11);
int numero2 = numeros.Next(1, 11);

Console.WriteLine($"\r\n\r\nEle tira duas cartas, ainda com os olhos fixos em cada movimento seu. \n“Ótimo! O primeiro número foi {numero1} e o " +
  $"segundo número foi {numero2}. Agora, me diga, você acha que a próxima carta será maior ou menor que as duas que saíram?” " +
  $"\r\n\r\n1 -> Maior que ambos \n2 -> Menor que ambos ");

int.TryParse(Console.ReadLine(), out int palpite);
int numero3 = numeros.Next(1, 11);
Console.WriteLine($"O número da carta três é {numero3}.");

//Ganha ma
if (palpite == 1 && numero3 > numero1 && numero3 > numero2)
{
    pontuacao += 1;
    Console.WriteLine($"Vitória! O número é maior que ambos! \r\n\r\nPontuação \nVocê -> {pontuacao}\nPalhaço -> {pontuacaopalhaco}. \r\n\r\nO palhaço" +
      "se impressiona com sua sorte, mas ainda sorri como sempre. \n“Você é realmente algo especial, não é? Vamos ver quem ganhou!”");
}
//Ganha me
else if (palpite == 2 && numero3 < numero1 && numero3 < numero2)
{
    pontuacao -= 1;
    Console.WriteLine($"Vitória! O número é maior que ambos! \r\n\r\nPontuação \nVocê -> {pontuacao}\nPalhaço -> {pontuacaopalhaco}. " +
      "\r\n\r\nO palhaço se impressiona com sua sorte, mas ainda sorri como sempre. \n“Você é realmente algo especial, não é? " +
      "Vamos ver quem ganhou!”");
}

//Perde
else
{
    pontuacaopalhaco += 1;
    Console.WriteLine($"Perdeu! O número é menor que ambos! \r\n\r\nPontuação \nVocê -> {pontuacao}\nPalhaço -> {pontuacaopalhaco}. \r\n\r\n" +
      "O palhaço não fica surpreso e apenas guarda as cartas.\n“Não foi dessa vez, não é? Tudo bem, vamos ver quem ganhou!”");
}


Console.WriteLine($"\r\n\r\nO palhaço se aproxima, o rosto a poucos centímetros do seu, examinando sua alma. " +
  $"\n“Sua jornada termina aqui... Você acumulou um total de {pontuacao} pontos.”");

if (pontuacao >= 2) //Final Bom
{
    Console.WriteLine("\r\n\r\n O palhaço recua e faz uma reverência exagerada, quase tocando o chão. \n“INACREDITÁVEL! O destino sempre esteve" +
      " com você, cavaleiro. As portas do circo se abrem para você!. A capital o espera e que a sorte nunca o abandone!”");
    Console.WriteLine("\n [ FINAL: A LENDA DO CAVALEIRO AFORTUNADO ]");
}

else //Final ruim
{
    Console.WriteLine("\r\n\r\n O palhaço explode em uma gargalhada ensurdecedora que ecoa por todo o local.");
    Console.WriteLine("“OH, que maravilhoso! Você perdeu tudo! Sua alma agora pertence ao circo e ao meu show para sempre! Hahahaha!!!”");
    Console.WriteLine("\n [ FINAL: A NOVA PARTE DO SHOW ]");
}
