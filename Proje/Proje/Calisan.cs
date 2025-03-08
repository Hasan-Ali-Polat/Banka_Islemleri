using System;

class Calisan
{
    public int Id { get; set; }
    public string Isim { get; set; }
    public double Maas { get; set; }
    public string Departman { get; set; }

    public Calisan(int id, string isim, double maas, string departman)
    {
        Id = id;
        Isim = isim;
        Maas = maas;
        Departman = departman;
    }

    public virtual double PrimHesapla()
    {
        return 0; 
    }
}