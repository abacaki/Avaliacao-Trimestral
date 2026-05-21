Console.OutputEncoding = System.Text.Encoding.UTF8;

introducao();
List<double> guardarNotas = new List<double>();
digitarNota();
soma(guardarNotas);
void introducao()
{
    Console.WriteLine("🪄 Bem-vindo(a) à Academia Mágica! Nesse programa será possível calcular a nota final dos alunos de feitiçaria e " +
        "decretar se eles avançarão de nível!");
}

void digitarNota()
{
    for (int i = 1; i <= 4; i++)
    {
        Console.WriteLine("\nDigite a nota de seu aluno:");
        double.TryParse(Console.ReadLine()!, out double nota);
        guardarNotas.Add(nota);

    }
}
double soma(List<double> guardarNotas)
{
    double soma = 0;
    foreach (double nota in guardarNotas) 
    {
        soma += nota;
    }
    double resultado = soma / guardarNotas.Count;

    Console.WriteLine($"\nA média final é: {resultado}");

    if (resultado >= 6)
    {
        Console.WriteLine("\n✨ Aprovado! O aprendiz avançou para o próximo nível arcano!");
    }

    else
    {
        Console.WriteLine("\n🌑 Reprovado! O aprendiz precisará estudar mais os grimórios...");
    }

    return resultado;
}



