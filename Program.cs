Console.OutputEncoding = System.Text.Encoding.UTF8;

int resultado;

Console.WriteLine("Bem vindo a loja de Thorin, aventureiro! Vamos ajudá-lo a calcular o valor de seus equipamentos!");
int LerMoedas() 
{
    Console.WriteLine("Digite o valor do seu equipamento: ");

    if (int.TryParse(Console.ReadLine()!, out int valor))
    {
        return valor;
    }
    else
    {
        Console.WriteLine("\n⚠️ Alerta de Goblin 👺 \nEntrada inválida! Valor definido como 0 moedas.");
        return 0;
    }
}

int somarEquipamentos (int valor1, int valor2)
{
    return valor1 + valor2;
}

Console.WriteLine("\nPrimeiro item");
int item1 = LerMoedas();

Console.WriteLine("\nSegundo item");
int item2 = LerMoedas();

resultado = somarEquipamentos(item1, item2);

Console.WriteLine($"\n💎 Conta Final: \r\n\r\nO total dos seus equipamentos ficou em {resultado} moedas de ouro.");
Console.WriteLine("Thorin agradece! Equipamentos prontos para a próxima masmorra ⚔️");