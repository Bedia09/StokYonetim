using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi
{
    public class Urun
    {
        private int stokMiktari;
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public int StokMiktari
        {
            get { return stokMiktari; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Stok adedi negatif bir değer olamaz.");
                else
                    stokMiktari = value;

            }
        }
        public Urun(int id, string ad, decimal fiyat, int stok)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
            StokMiktari = stok;
        }
        public void StokGuncelle (int miktar)
        {
            if (StokMiktari+miktar<0)
                Console.WriteLine("Yetersiz stok");
            else
                StokMiktari = miktar;
        }
        public override string ToString()
        {
            return Id+ "-" + Ad + " | " + Fiyat + "₺ | Stok:" + StokMiktari;
        }  
    }
}