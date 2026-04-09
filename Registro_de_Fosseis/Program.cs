//Registro de Fósseis - Yuri Saito Mena

Console.WriteLine("Uma misteriosa arqueóloga quer que você registre alguns fósseis. Escolha um número para registrá-los:");

for (int f = 0; f <= 7; f++)
{
    Console.WriteLine("\r\n\r\nMenu de Fósseis: \r\n\r\n1 - Poríferos \n2 - Cnidários \n3 - Platelmintos \n4 - Moluscos \n5 - Anelídeos \n6 - Antrópodes" +
    "\n7 - Urocordados");
    int.TryParse(Console.ReadLine(), out int ff);

    switch (ff)
    {

        case 1:
            Console.WriteLine("Você registou Poríferos no sistema.");
            break;
        case 2:
            Console.WriteLine("Você registou Cnidários no sistema.");
            break;
        case 3:
            Console.WriteLine("Você resgistrou Platelmintos no sistema.");
            break;
        case 4:
            Console.WriteLine("Você resgistrou Moluscos no sistema.");
            break;
        case 5:
            Console.WriteLine("Você resgistrou Anelídios no sistema.");
            break;
        case 6:
            Console.WriteLine("Você resgistrou Antrópodes no sistema.");
            break;
        case 7:
            Console.WriteLine("Você resgistrou Urocordados no sistema.");
            break;
        default:
            Console.WriteLine("Você não conseguiu registrar nada. Tente novamente");
            break;
    }
}