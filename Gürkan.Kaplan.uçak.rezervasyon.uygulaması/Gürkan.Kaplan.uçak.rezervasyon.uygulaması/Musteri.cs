using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class Musteri
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yaş { get; set; }

        public string KimlikNo { get; set; }

        public string IletisimNo { get; set; }

        public int Cinsiyet { get; set; }

        public int Engelli { get; set; }

        public Musteri(string ad, string soyad, string yas, string kimlikNo, string ıletisimNo, int cinsiyet, int engelli)
        {
            Ad = ad;
            Soyad = soyad;
            Yaş = yas;
            KimlikNo = kimlikNo;
            IletisimNo = ıletisimNo;
            Cinsiyet = cinsiyet;
            Engelli = engelli;
        }
    }
}