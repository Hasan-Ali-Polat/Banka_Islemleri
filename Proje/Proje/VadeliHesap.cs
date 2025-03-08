class VadeliHesap : BankaHesabi
{
    public VadeliHesap(string hesapSahibi, double bakiye)
        : base(hesapSahibi, bakiye) { }

    public override void FaizHesapla()
    {
        Console.WriteLine($"Vadeli Hesap Faizi: {Bakiye * 0.05}");
    }
}