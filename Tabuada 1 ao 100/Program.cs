//Tabuada 1 ao 100 - Yuri Saito Mena

int n1 = 1; int n2 = 2; int n3 = 3; int n4 = 4; int n5 = 5; int n6 = 6; int n7 = 7; int n8 = 8; int n9 = 9; int n10 = 10;

Console.WriteLine("Tabuada do 1 ao 10:");

for (int n = 1; n <= 10; n++)
{
    Console.WriteLine($"\nTabuada do número {n}: \n");
    Console.WriteLine($"{n} * {n1} = {n * n1}");
    Console.WriteLine($"{n} * {n2} = {n * n2}");
    Console.WriteLine($"{n} * {n3} = {n * n3}");
    Console.WriteLine($"{n} * {n4} = {n * n4}");
    Console.WriteLine($"{n} * {n5} = {n * n5}");
    Console.WriteLine($"{n} * {n6} = {n * n6}");
    Console.WriteLine($"{n} * {n7} = {n * n7}");
    Console.WriteLine($"{n} * {n8} = {n * n8}");
    Console.WriteLine($"{n} * {n9} = {n * n9}");
    Console.WriteLine($"{n} * {n10} = {n * n10}");
}

