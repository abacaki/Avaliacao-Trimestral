//Calculadora Temperatura - Yuri Saito Mena

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Conversor de Temperaturas - Escolha uma operação \n 🥇1.Celsius (°C) para Fahrenheit (°F); \n 🥈2.Fahrenheit (°F) para Celsius (°C); " +
    "\n 🥉3.Kelvin (K) para Celsius (°C); \n 🏅4.Kelvin (K) para Fahrenheit (°F).");

string escolha = Console.ReadLine();


//1. C p/ F 
if (escolha == "1")

{
    Console.WriteLine("Celsius (°C) para Fahrenheit (°F): \n ❤️Escolha o número em C° para a coverter em F°");
    float.TryParse(Console.ReadLine(), out float celsius);
    float resultado = (celsius * 9 / 5) + 32;
    if (resultado > 76.9)
        Console.WriteLine($"A conversão de {celsius} C° é igual a {resultado} F°🔥");
    if (resultado < 60)
        Console.WriteLine($"A conversão de {celsius} C° é igual a {resultado} F°❄️");
    if (resultado > 60 & resultado < 76.9)
        Console.WriteLine($"A conversão de {celsius} C° é igual a {resultado} F°🌡️");
}

//2. F p/ C
if (escolha == "2")
{
    Console.WriteLine("Fahrenheit (°F) para Celsius (°C): \n 💙Escolha o número em F° para a coverter em C°");
    float.TryParse(Console.ReadLine(), out float fahrenheit);
    float resultado1 = (fahrenheit - 32) * 5 / 9;
    if (resultado1 > 24.9)
        Console.WriteLine($"A conversão de {fahrenheit} F° é igual a {resultado1} C°🔥");
    if (resultado1 < 15.6)
        Console.WriteLine($"A conversão de {fahrenheit} F° é igual a {resultado1} C°❄️");
    if (resultado1 > 15.6 & resultado1 < 24.9)
        Console.WriteLine($"A conversão de {fahrenheit} F° é igual a {resultado1} C°🌡️");
}

//3. K p/ C
if (escolha == "3")
{
    Console.WriteLine("Kelvin (K) para Celsius (°C): \n 💚Escolha o número em K para a coverter em C°");
    float.TryParse(Console.ReadLine(), out float kelvin);
    float resultado2 = kelvin - 273.15f;
    if (resultado2 > 24.9)
        Console.WriteLine($"A conversão de {kelvin} K é igual a {resultado2} C°🔥");
    if (resultado2 < 15.6)
        Console.WriteLine($"A conversão de {kelvin} K é igual a {resultado2} C°❄️");
    if (resultado2 > 15.6 & resultado2 < 24.9)
        Console.WriteLine($"A conversão de {kelvin} K é igual a {resultado2} C°🌡️");
}

//4. K p/ F
if (escolha == "4")
{
    Console.WriteLine("Kelvin (K) para Fahrenheit (°F): \n 💛Escolha o número em K para a coverter em C°");
    float.TryParse(Console.ReadLine(), out float kef);
    float resultado3 = (kef - 273.15f) * 9 / 5 + 32;
    if (resultado3 > 76.9)
        Console.WriteLine($"A conversão de {kef} K é igual a {resultado3} F°🔥");
    if (resultado3 < 60)
        Console.WriteLine($"A conversão de {kef} K é igual a {resultado3} F°❄️");
    if (resultado3 > 60 & resultado3 < 76.9)
        Console.WriteLine($"A conversão de {kef} K é igual a {resultado3} F°🌡️");
}
