using System;

class Program
{
    static void Main(string[] args)
    {
        Aplikace aplikace = new Aplikace();

        Console.WriteLine("------------------------------");
        Console.WriteLine("Evidence Pojistenych");
        Console.WriteLine("------------------------------");

        while (true)
        {
            Console.WriteLine("\n1 - Vytvorit pojisteneho");
            Console.WriteLine("2 - Zobrazit seznam pojistenych");
            Console.WriteLine("3 - Vyhledat pojisteneho");
            Console.WriteLine("4 - Ulozit data");
            Console.WriteLine("5 - Nacíst data");
            Console.WriteLine("0 - Konec");

            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    Console.WriteLine("Zadejte jmeno:");
                    string jmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte prijmeni:");
                    string prijmeni = Console.ReadLine();

                    Console.WriteLine("Zadejte vek:");
                    int vek = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zadejte telefonni cislo:");
                    string telefon = Console.ReadLine();

                    aplikace.VytvorPojisteneho(jmeno, prijmeni, vek, telefon);
                    break;
                case "2":
                    aplikace.ZobrazSeznamPojisteny();
                    break;
                case "3":
                    Console.WriteLine("Zadejte jmeno:");
                    jmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte prijmeni:");
                    prijmeni = Console.ReadLine();

                    aplikace.VyhledejPojisteneho(jmeno, prijmeni);
                    break;
                case "4":
                    Console.WriteLine("Zadejte nazev souboru pro ulozeni dat:");
                    string nazevUlozit = Console.ReadLine();
                    aplikace.UlozData(nazevUlozit);
                    break;
                case "5":
                    Console.WriteLine("Zadejte nazev souboru pro nacteni dat:");
                    string nazevNacist = Console.ReadLine();
                    aplikace.NactiData(nazevNacist);
                    break;
                case "0":
                    Console.WriteLine("Aplikace ukoncena.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Neplatna volba.");
                    break;
            }
        }
    }
}
