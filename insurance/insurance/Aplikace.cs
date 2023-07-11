using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Aplikace
{
    private List<Pojisteny> seznamPojisteny;

    public Aplikace()
    {
        seznamPojisteny = new List<Pojisteny>();
    }

    public void VytvorPojisteneho(string jmeno, string prijmeni, int vek, string telefon)
    {
        Pojisteny pojisteny = new Pojisteny(jmeno, prijmeni, vek, telefon);
        seznamPojisteny.Add(pojisteny);
        Console.WriteLine("Pojisteny byl uspesne vytvoren.");
    }

    public void ZobrazSeznamPojisteny()
    {
        if (seznamPojisteny.Count == 0)
        {
            Console.WriteLine("Neexistuji zadni pojisteni.");
        }
        else
        {
            foreach (Pojisteny pojisteny in seznamPojisteny)
            {
                Console.WriteLine("\n" + pojisteny);
            }
        }
    }

    public void VyhledejPojisteneho(string jmeno, string prijmeni)
    {
        bool nalezeno = false;
        foreach (Pojisteny pojisteny in seznamPojisteny)
        {
            if (pojisteny.Jmeno.Equals(jmeno, StringComparison.OrdinalIgnoreCase) &&
                pojisteny.Prijmeni.Equals(prijmeni, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n" + pojisteny);
                nalezeno = true;
                break;
            }
        }
        if (!nalezeno)
        {
            Console.WriteLine("Pojisteny s timto jmenem a prijmenim nebyl nalezen.");
        }
    }

    public void UlozData(string nazevSouboru)
    {
        string json = JsonSerializer.Serialize(seznamPojisteny);
        File.WriteAllText(nazevSouboru, json);
        Console.WriteLine("Data byla uspesne ulozena.");
    }

    public void NactiData(string nazevSouboru)
    {
        if (File.Exists(nazevSouboru))
        {
            string json = File.ReadAllText(nazevSouboru);
            seznamPojisteny = JsonSerializer.Deserialize<List<Pojisteny>>(json);
            Console.WriteLine("Data byla uspesne nactena.");
        }
        else
        {
            Console.WriteLine("Soubor s daty neexistuje.");
        }
    }
}
