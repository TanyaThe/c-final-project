﻿class Pojisteny
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public int Vek { get; set; }
    public string Telefon { get; set; }

    public Pojisteny(string jmeno, string prijmeni, int vek, string telefon)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Vek = vek;
        Telefon = telefon;
    }

    public override string ToString()
    {
        return Jmeno + "\t" +
               Prijmeni + "\t" +
               Vek + "\t" +
               Telefon;
    }
}
