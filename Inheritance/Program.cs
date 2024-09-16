using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BaseKisi
{
    // Propertyler
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // Konsola ad ve soyad yazdıran metot
    public void AdSoyadYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

class Ogrenci : BaseKisi
{
    // Ogrenci için ilave property
    public string OgrenciNo { get; set; }

    // Konsola öğrenci numarası, ad ve soyad yazdıran metot
    public void OgrenciBilgileriYazdir()
    {
        Console.WriteLine($"Öğrenci No: {OgrenciNo}");
        AdSoyadYazdir(); // BaseKisi'den miras alınan metodu çağırıyoruz
    }
}

class Ogretmen : BaseKisi
{
    // Ogretmen için ilave property
    public decimal Maas { get; set; }

    // Konsola maaş bilgisi, ad ve soyad yazdıran metot
    public void OgretmenBilgileriYazdir()
    {
        Console.WriteLine($"Maaş: {Maas}");
        AdSoyadYazdir(); // BaseKisi'den miras alınan metodu çağırıyoruz
    }
}

class Program
{
    static void Main()
    {
        // Öğrenci nesnesi oluşturuluyor
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "Okan";
        ogrenci.Soyad = "Kaya";
        ogrenci.OgrenciNo = "12345";

        // Öğrenci bilgileri yazdırılıyor
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci.OgrenciBilgileriYazdir();

        // Öğretmen nesnesi oluşturuluyor
        Ogretmen ogretmen = new Ogretmen();
        ogretmen.Ad = "Ayşe";
        ogretmen.Soyad = "Demir";
        ogretmen.Maas = 5000m;

        // Öğretmen bilgileri yazdırılıyor
        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen.OgretmenBilgileriYazdir();
    }
}
