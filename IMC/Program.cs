//IMC - Yuri Saito Mena

Console.WriteLine("\nDigite a sua altura em m²");
double.TryParse(Console.ReadLine()!.Replace (".", ","), out double altura);

Console.WriteLine("Calculadora de IMC: \nDigite o seu peso:");
double.TryParse(Console.ReadLine()!.Replace (".", ","), out double peso);

double IMC = peso / Math.Pow(altura, 2.0);

if (IMC <= 18.5)
{ Console.WriteLine($"Você está abaixo do peso."); }

else if (IMC >= 18.5)
{ Console.WriteLine($"Você está em um peso ideal."); }

else if (IMC >= 25)
{ Console.WriteLine($"Você está em um peso com obesidade."); }

else if (IMC >= 30)
{ Console.WriteLine($"Você está em um peso com obesidade severa."); }