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
    }
}
