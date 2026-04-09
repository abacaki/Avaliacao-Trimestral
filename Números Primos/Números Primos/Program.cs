//Primos - Yuri Saito Mena

int cont = 0, resultado;
Console.WriteLine("Calculadora de Primos: \nSelecione um número e veja se ele é primo ou não!");
int.TryParse(Console.ReadLine(), out int numero);

for (int divisor = 1; divisor <= numero; divisor++)
{

    if (numero % divisor == 0)
    {
        
        cont++;
    }
}

if (cont == 2)
{
    Console.WriteLine($"\nO numero {numero} é primo!");

}
else
{
    Console.WriteLine($"\nO número {numero} não é primo!");
}