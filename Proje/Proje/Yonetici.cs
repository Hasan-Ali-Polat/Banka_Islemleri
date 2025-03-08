class Yonetici : Calisan
{
    public int EkipBoyutu { get; set; }

    public Yonetici(int id, string isim, double maas, string departman, int ekipBoyutu)
        : base(id, isim, maas, departman)
    {
        EkipBoyutu = ekipBoyutu;
    }

    public override double PrimHesapla()
    {
        return Maas * 0.20; // %20 Prim
    }
}