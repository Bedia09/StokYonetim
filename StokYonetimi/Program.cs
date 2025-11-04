using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi
{
    public class Program
    {
         static void Main(string[] args)
        {
           StokYonetimi stok = new StokYonetimi();

            Kategori kirtasiyeKategori = new Kategori(1, "Kırtasiye");
            Urun kalem = new Urun(1, "Kalem", 20, 40);
            Urun silgi = new Urun(2, "Silgi", 10, 30);
            Urun defter = new Urun(3, "Defter", 15, 35);

            kirtasiyeKategori.UrunEkle (kalem);
            kirtasiyeKategori.UrunEkle (silgi);
            kirtasiyeKategori.UrunEkle (defter);

            stok.KategoriEkle (kirtasiyeKategori);
            stok.TumStokListele();

            Console.WriteLine("\nStok güncelleme:");
            kalem.StokGuncelle(-5);
            Console.WriteLine(kalem.ToString());

        }
    }
}