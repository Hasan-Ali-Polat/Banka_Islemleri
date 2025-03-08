class VadesizHesap : BankaHesabi
{
    public VadesizHesap(string hesapSahibi, double bakiye)
        : base(hesapSahibi, bakiye) { }

    public override void FaizHesapla()
    {
        Console.WriteLine("Vadesiz hesaplarda faiz kazancı yoktur.");
    }
}