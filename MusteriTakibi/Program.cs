using System;

namespace MusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Donbaloğlu";
            musteri1.TelNo = 1646831;
            musteri1.Adres = "Bursa";

            Musteri musteri2=new Musteri { Id=20, Ad="Burak", Soyad="Sarlak", TelNo=563134, Adres="Istanbul"};

            MusteriManager musteriManager=new MusteriManager();   
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Goster(musteri1);
        }
    }
}