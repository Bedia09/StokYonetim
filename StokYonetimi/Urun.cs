using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokYonetimi
{
    public class Urun
    {
        private int stokAdedi;
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public int StokAdedi
        {
            get { return stokAdedi; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Stok adedi negatif bir değer olamaz.");
                else
                    stokAdedi = value;

            }
        }
        public Urun(int id, string ad, decimal fiyat, int stok)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
            StokAdedi = stok;
        }
        

        
    }
}