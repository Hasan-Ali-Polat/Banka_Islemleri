class Gelistirici : Calisan
{
    public string Hakkinda { get; set; }

    public Gelistirici(int id, string isim, double maas, string departman, string hakkinda)
        : base(id, isim, maas, departman)
    {
        Hakkinda = hakkinda;
    }

    public override double PrimHesapla()
    {
        return Maas * 0.10; // %10 Prim
    }
}