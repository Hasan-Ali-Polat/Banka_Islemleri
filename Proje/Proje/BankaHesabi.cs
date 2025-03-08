class BankaHesabi
{
    public string HesapSahibi { get; set; }
    public double Bakiye { get; set; }

    public BankaHesabi(string hesapSahibi, double bakiye)
    {
        HesapSahibi = hesapSahibi;
        Bakiye = bakiye;
    }

    public virtual void FaizHesapla()
    {
        Console.WriteLine("Faiz hesaplaması uygulanmadı.");
    }
}