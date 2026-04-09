//Raiz Quadrada - Yuri Saito Mena

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Mago Merlin 🧙 precisa que você calcule por 3 vezes a área de um quadrado 🟦 \nDigite o valor da base:");
int.TryParse(Console.ReadLine(), out int qq);
Console.WriteLine($"\nO lado do quadrado é: {qq}");

int areaq = (qq * qq);

for (int q = 1; q <= 3; q++)
{
    Console.WriteLine($"\nA área do quadrado é {areaq}");
}