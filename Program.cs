


using Practicum_Functies_NASServer;

NASServer server = new NASServer();

Console.WriteLine("SAN BEHEER");
Console.WriteLine("==========");
Console.WriteLine("Geef de nodige SAN gegevens in: ");

bool inputOK = true;
do
{
    inputOK = true;
    Console.Write("RAID ondersteuning instellen (j/n)?: ");
    string raid = Console.ReadLine();
    switch (raid)
    {
        case "j":
            server.RaidSet = true;
            break;
        case "n":
            server.RaidSet = false;
            break;
        default:
            inputOK = false;
            Console.WriteLine("Gelieve j of n in te geven");
            break;
    }
} while (!inputOK);


Console.WriteLine("Gelieve de gegevens van harddisk 1 in te geven");
Console.Write("\tModel: ");
server.Harddisk1.Model = Console.ReadLine();
Console.Write("\tGrootte (Tb): ");
server.Harddisk1.Size = int.Parse(Console.ReadLine());

Console.WriteLine("Gelieve de gegevens van harddisk 2 in te geven");
Console.Write("\tModel: ");
server.Harddisk2.Model = Console.ReadLine();
Console.Write("\tGrootte (Tb): ");
server.Harddisk2.Size = int.Parse(Console.ReadLine());




string menu = string.Empty;

do
{
    Console.WriteLine("Kies een optie uit onderstaand menu:");
    Console.WriteLine(" 1. Geef NAS server overzicht");
    Console.WriteLine(" 2. Controleer RAID");
    Console.WriteLine(" 3. Stop programma");
    Console.Write(">");
    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.WriteLine(server.GetDescription());
            break;
        case "2":
            string detail = string.Empty;
            do
            {
                Console.WriteLine("Detail info (j/n): ");
                detail = Console.ReadLine();
                if (detail != "j" && detail != "n")
                {
                    Console.WriteLine("Gelieve geef 'j' of 'n' in te geven");
                }

            } while (detail != "j" && detail != "n");

            bool isDetail = (detail == "j") ? true : false;
            Console.WriteLine(server.CheckRaid(isDetail));
            break;
        case "3":
            break;
        default:
            Console.WriteLine("Ongeldige menu keuze");
            break;
    }
    if (menu != "3")
    {
        Console.WriteLine("Druk op een toets");
        Console.ReadLine();
    }
} while (menu != "3");


