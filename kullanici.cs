using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    internal class deneme
    {


        abstract class Kullanici
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Tc { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string Cinsiyet { get; set; }
            public string UyelikTuru { get; set; }

            // Parametreli constructor
            public Kullanici(string ad, string soyad, string tc, DateTime dogumTarihi, string cinsiyet, string uyelikTuru)
            {
                Ad = ad;
                Soyad = soyad;
                Tc = tc;
                DogumTarihi = dogumTarihi;
                Cinsiyet = cinsiyet;
                UyelikTuru = uyelikTuru;
            }

            // Soyut metot: Üyelik ücreti hesaplaması
            public abstract double HesaplaUyelikUcreti();
        }

        class StandartKullanici : Kullanici
        {
            // Parametreli constructor
            public StandartKullanici(string ad, string soyad, string tc, DateTime dogumTarihi, string cinsiyet)
                : base(ad, soyad, tc, dogumTarihi, cinsiyet, "Standart")
            {
            }

            // Standart kullanıcılar için üyelik ücreti hesaplaması
            public override double HesaplaUyelikUcreti()
            {
                // İndirimsiz fiyat olarak 100TL
                return 100;
            }
        }

        class PremiumKullanici : Kullanici
        {
            // Parametreli constructor
            public PremiumKullanici(string ad, string soyad, string tc, DateTime dogumTarihi, string cinsiyet)
                : base(ad, soyad, tc, dogumTarihi, cinsiyet, "Premium")
            {
            }

            // Premium kullanıcılar için üyelik ücreti hesaplaması
            public override double HesaplaUyelikUcreti()
            {
                // İndirimsiz fiyat olarak 100TL'ye %25 artış
                return 100 * 1.25;
            }
        }



    }
}
