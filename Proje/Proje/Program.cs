class Program
{
    static void Main(string[] args)
    {
        // Çalışan Testi
        Yonetici yonetici = new Yonetici(1, "Hasan", 125000, "yonetici",15);
        Gelistirici gelistirici = new Gelistirici(2, "Melek", 55000, "IT", "Full-Stack Geliştirici");

        Console.WriteLine($"Yönetici Primi: {yonetici.PrimHesapla()}");
        Console.WriteLine($"Geliştirici Primi: {gelistirici.PrimHesapla()}");

        // Banka Hesabı Testi
        VadeliHesap vadeli = new VadeliHesap("Ali", 100000);
        VadesizHesap vadesiz = new VadesizHesap("Veli", 50000);

        vadeli.FaizHesapla();
        vadesiz.FaizHesapla();
    }
}