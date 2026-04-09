Console.OutputEncoding = System.Text.Encoding.UTF8;

float Moeda, ConversorReal, Resultado;
int Escolha;

Console.WriteLine("Conversor de Moedas 🪙");
Console.WriteLine("Digite o valor em Reais que deseja converter:    ");
float.TryParse(Console.ReadLine()!, out Moeda);

Console.WriteLine("\nDigite 1 para converter para Dólar \nDigite 2 para converter para Libras");
int.TryParse(Console.ReadLine()!, out Escolha);

switch (Escolha)
{
    case 1:
        Console.WriteLine("Digite o valor atual do Dólar:    ");
        float.TryParse(Console.ReadLine()!, out ConversorReal);
        Resultado = Moeda * ConversorReal;
        Console.WriteLine($"R${Moeda} x U${ConversorReal} = R${Resultado}");
        break;
    case 2:
        Console.WriteLine("Digite o valor atual da Libra:    ");
        float.TryParse(Console.ReadLine()!, out ConversorReal);
        Resultado = Moeda * ConversorReal;
        Console.WriteLine($"R${Moeda} x U${ConversorReal} = R${Resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
}
