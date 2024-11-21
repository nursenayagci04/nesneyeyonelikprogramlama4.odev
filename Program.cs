// See https://aka.ms/new-console-template for more information
using System;
/**** SORU 1 ***

class Program
{
    static double UcgeninAlaniniHesapla(double taban, double yukseklik)
    {
        return (taban * yukseklik) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Üçgenin taban uzunluğunu giriniz: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini giriniz: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        double alan = UcgeninAlaniniHesapla(taban, yukseklik);

        Console.WriteLine($"Üçgenin alanı: {alan}");
    }
}

*/

/**** SORU 2 
 using System;

class Program
{
    static int EnBuyukDegeriBul(int[] dizi)
    {
        int enBuyuk = dizi[0];

        foreach (int deger in dizi)
        {
            if (deger > enBuyuk)
            {
                enBuyuk = deger;
            }
        }

        return enBuyuk;
    }

    static void Main(string[] args)
    {
        int[] sayilar = { 22, 44, 23, 777, 53, 81, 99 };

        int enBuyukDeger = EnBuyukDegeriBul(sayilar);
        Console.WriteLine($"Dizideki en büyük değer: {enBuyukDeger}");
    }
}
*/

/**** 3.SORU ***

using System;

class Program
{
    static int CalculateSum(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    static double CalculateSum(double sayi1, double sayi2)
    {
        return sayi1 + sayi2;
    }
    static int CalculateSum(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

    static void Main(string[] args)
    {
        int intToplam = CalculateSum(44, 88);
        Console.WriteLine($"İki int sayının toplamı: {intToplam}");

        double doubleToplam = CalculateSum(22.2, 77.7);
        Console.WriteLine($"İki double sayının toplamı: {doubleToplam}");

        int ucIntToplam = CalculateSum(20, 40, 80);
        Console.WriteLine($"Üç int sayının toplamı: {ucIntToplam}");
    }
}
*/

/**** 4.SORU
using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Fibonacci dizisinin hangi elemanını öğrenmek istiyorsunuz? ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sonuc = Fibonacci(n);
        Console.WriteLine($"Fibonacci({n}) = {sonuc}");
    }
}
*/

/**** 5.SORU

using System;

class Program
{
    static double OrtalamaHesapla(params double[] sayilar)
    {
        double toplam = 0;

        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }

        return sayilar.Length > 0 ? toplam / sayilar.Length : 0;
    }

    static void Main(string[] args)
    {

        double ortalama1 = OrtalamaHesapla(12.2, 18.81, 53.53);
        double ortalama2 = OrtalamaHesapla(10.0, 20.0);
        double ortalama3 = OrtalamaHesapla(5.0, 70.0, 16.0, 80.0, 40.0);

        // Sonuçları ekrana yazdırma
        Console.WriteLine($"Ortalama 1: {ortalama1}");
        Console.WriteLine($"Ortalama 2: {ortalama2}");
        Console.WriteLine($"Ortalama 3: {ortalama3}");
    }
}

*/

/**** 6.SORU***
 
using System;

class Program
{
    static int ToplaFiltreyeGore(int[] dizi, int filtreDeğeri)
    {
        int toplam = 0;

        foreach (int eleman in dizi)
        {
            if (eleman > filtreDeğeri)
            {
                toplam += eleman;
            }
        }

        return toplam;
    }

    static void Main(string[] args)
    {
        int[] sayilar = { 22, 44, 66, 80, 90, 77, 53 };

        int filtre = 53;

        int toplam = ToplaFiltreyeGore(sayilar, filtre);

        Console.WriteLine($"Filtre değerinden ({filtre}) büyük olan sayıların toplamı: {toplam}");
    }
}
*/

/****7.SORU
using System;

class Program
{
    static int YasFarki(int yas = 18)
    {
        return yas - 18;
    }

    static void Main(string[] args)
    {
        int fark1 = YasFarki();

        Console.Write("Yaşınızı girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        int fark2 = YasFarki(yas);
        Console.WriteLine($"Verilen yaş ile 18 arasındaki fark: {fark2}");
    }
}

*/
using System;
using System.Collections.Generic;

class Program
{
    static List<string> Filtrele_Uzunluk_5tenBuyuk(string[] dizi)
    {
        List<string> sonucListesi = new List<string>();

        foreach (string eleman in dizi)
        {
            if (eleman.Length > 5)
            {
                sonucListesi.Add(eleman);
            }
        }

        return sonucListesi;
    }

    static void Main(string[] args)
    {
        string[] kelimeler = { "ICARDI", "ARDA", "FATIHTERIM", "MUSLERA", "BARISALPER", "OSIMHEN" };

        List<string> uzunKelimeListesi = Filtrele_Uzunluk_5tenBuyuk(kelimeler);

        Console.WriteLine("Uzunluğu 5'ten büyük olan kelimeler:");
        foreach (string kelime in uzunKelimeListesi)
        {
            Console.WriteLine(kelime);
        }
    }
}
