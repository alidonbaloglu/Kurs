using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakibi
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: "+ musteri.Ad+" "+  musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Goster(Musteri musteri)
        {

            Console.WriteLine("Görüntülenen Müşteriler: "+ musteri.Ad + " " + musteri.Soyad);
        }

    }
}
