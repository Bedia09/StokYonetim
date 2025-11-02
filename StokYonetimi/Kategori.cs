using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Urun> Urunler { get; set; }
        public Kategori(int id, string ad)
        {
            Id = id;
            Ad = ad;
            Urunler = new List<Urun>();
        }
        public void UrunEkle (Urun urun)
        {
            Urunler.Add(urun);
            Console.WriteLine(urun.Ad + "ürünü '" + Ad + "' kategorisine eklendi.");
        }
        public override string ToString()
        {
            return Id + " - " + Ad + " | Ürün Sayısı: " + Urunler.Count;
        }
    }
}
