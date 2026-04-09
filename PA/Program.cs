//PA - Yuri Saito Mena

int Termos, Salto, Resultado = 0;

Console.WriteLine("Calculadora de PA:   ");

Console.WriteLine("Digite a quantidade de termos da sequência:");
int.TryParse(Console.ReadLine()!, out Termos);
Console.WriteLine("Digite o valor do salto da sequência:    ");
int.TryParse(Console.ReadLine()!, out Salto);

for (int an = 1; an <= Termos; an = an + Salto)
{
    Resultado = Resultado + Salto;
    Console.WriteLine($"Sua sequencia de PA é {Resultado}");
}