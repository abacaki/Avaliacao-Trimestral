Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo, mestre da alquimia! ⚗️🥼");
Console.WriteLine("\r\nVocê foi chamado pela Guilda dos Aventureiros para testarmos as potências de suas poções!");

List<string> NomePocoes = new List<string>(); 
NomePocoes.Add("Poção de Regeneração");
NomePocoes.Add("Poção de de Agilidade ");
NomePocoes.Add("Poção de Resistência ao Fogo");
NomePocoes.Add("Poção de Visão Noturna");
NomePocoes.Add("Poção de Força");

double[] PotenciasPocoes = new double[5] { 65.5, 50, 40.5, 35, 80 };
Console.WriteLine("\r\nAqui, habilidoso arqueiro, está as suas poções e suas potências:");

double SomaPotencias = 0;
for (int i = 0; i < PotenciasPocoes.Length; i++)
{
    SomaPotencias = SomaPotencias + PotenciasPocoes[i];
    Console.WriteLine($"🧪 {NomePocoes[i]}: {PotenciasPocoes[i]} de potência.");
}

double MediaPotencia = SomaPotencias / PotenciasPocoes.Length;
Console.WriteLine($"\r\n⚡A soma de suas potências é igual a: {SomaPotencias} \n A média de potência de suas poções é: " +
    $"{MediaPotencia} 🍀 ");
    