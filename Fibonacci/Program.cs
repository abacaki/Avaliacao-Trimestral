//Fibonacci - Yuri Saito Mena

//Variaveis
int termos, n1 = 0, n2 = 1, n3 = 0;

Console.WriteLine("Digite o número de termos");
int.TryParse(Console.ReadLine(), out termos);
//Console.WriteLine("Digite o número do salto");
//int.TryParse(Console.ReadLine(), out int salto);

Console.WriteLine("Os números da sequência são:   ");

for (int i = 1; i <= termos; i++)
{
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;

    Console.WriteLine($"\n{n3}");
}

