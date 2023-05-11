
using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class UcusOlusturma
    {
        public string Musteri;
        public string Ucak;
        public string UcakSeriNo;
        public string BagajKapasitesi;
        public string Lokasyon;
        public string Tarih;
        public string Saat;

        public UcusOlusturma(string Ad, string Soyad)
        {
            Musteri = Ad + " " + Soyad;

            UcakOlusturma ucakOlusturma = new UcakOlusturma();
            Ucak = ucakOlusturma.Model;
            UcakSeriNo = ucakOlusturma.SeriNo;
            BagajKapasitesi = ucakOlusturma.BagajKapasitesi;

            Console.WriteLine("\nEtkin Uçuşlar: ");
            LokasyonOlusturma lokasyonOlusturma = new LokasyonOlusturma();

            int LSayac = 1;
            foreach (var item in lokasyonOlusturma.LokasyonList)
            {
                Console.WriteLine(LSayac + ".Konum.txt =>" + item);
                LSayac++;
            }

            while (true)
            {
                Console.Write("Uçuş Lokasyonu Seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim >= 1 && secim <= LSayac - 1)
                {
                    Lokasyon = lokasyonOlusturma.LokasyonList[secim - 1];
                    break;
                }
            }

            Console.WriteLine("\nLütfen Tarih Giriniz (gün/ay/yıl): ");
            Tarih = Console.ReadLine();

            Console.WriteLine("\nLütfen Saat Giriniz (##:##):");
            Saat = Console.ReadLine();
      
        }

        public string UcusDondur()
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            string Temp = "\nSayın: " + Musteri + "\nUçağınız: " + Ucak + "\nUçak Seri Numaranız: " + UcakSeriNo + " \nLokasyonunuz: " + Lokasyon + "\nUçuş Tarihiniz: " + Tarih + "\nUçuç Saatiniz: " + Saat +"\nUçak Bagaj Hakkınız:"+ BagajKapasitesi + "\nBilet Tutarınız: " + rezervasyon.ucret;
            return Temp;
        }

    }
}
