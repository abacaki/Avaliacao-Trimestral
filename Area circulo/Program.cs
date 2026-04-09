//Area circulo - Yuri Saito Mena

Console.WriteLine("\nO Deus da profanidade 🕳️ lançou uma maldição em você e para combatê-la, é necessário calcular a área da circunferência 🔵 para que se " +
  "consiga invocar o círculo de proteção sagrado.\nDigite o raio do círculo:");
int.TryParse(Console.ReadLine(), out int c1);
Console.WriteLine($"O seu raio é {c1}");

double areac = ((3.14) * (c1 * c1));

if (areac > 10)
{
    Console.WriteLine("\nSua circunferência é maior que 10, você venceu a maldição. Obaaaaaa!!");
}
else
{
    Console.WriteLine("\nSua circunferência é menor que 10, você não venceu a maldição e passará o resto da sua vida trabalhando como vendedor " +
      "de cachorro quente sem salsicha e com dor 💔");
}

