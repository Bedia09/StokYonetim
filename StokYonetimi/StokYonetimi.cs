using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi
{
    public class StokYonetimi
    {
        public List<Kategori> Kategoriler { get; set; }
        public StokYonetimi()
        {
            Kategoriler = new List<Kategori>();
        }
        public void KategoriEkle (Kategori kategori)
        {
            Kategoriler.Add(kategori);
            Console.WriteLine(kategori.Ad + "kategorsisi eklendi.");
        }
        public void TumStokListele()
        {
            Console.WriteLine("\n Tüm Ürünler");
            foreach (var kategori in Kategoriler)
            {
                Console.WriteLine("\nKategori: " + kategori.Ad);
                if (kategori.Urunler.Count ==0)
                {
                    Console.WriteLine("Kategoride ürün bulunamadı");
                }
                else
                {
                    foreach (Urun urun in  kategori.Urunler)
                    {
                        Console.WriteLine(urun.ToString());
                    }
                }
            }
        }
    }
}
