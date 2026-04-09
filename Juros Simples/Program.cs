//Juros Simples - Yuri Saito Mena

Console.WriteLine("\nDigite o valor do Capital: ");
int.TryParse(Console.ReadLine(), out int capital);
Console.WriteLine($"O valor do seu capital é {capital}");

Console.WriteLine("\nDigite o valor da taxa:");
float.TryParse(Console.ReadLine(), out float taxa);
Console.WriteLine($"O valor da sua taxa é {taxa}%");

Console.WriteLine("\nDigite o valor do tempo:");
float.TryParse(Console.ReadLine(), out float tempo);
Console.WriteLine($"O valor do seu tempo é {tempo}");

float resultado = capital * taxa * tempo;

Console.WriteLine($"O valor do seu juros simples é: R${resultado}");
