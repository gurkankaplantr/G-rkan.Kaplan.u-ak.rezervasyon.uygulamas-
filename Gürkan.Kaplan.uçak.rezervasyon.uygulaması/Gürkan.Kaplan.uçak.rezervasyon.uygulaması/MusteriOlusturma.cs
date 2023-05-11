
using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class MusteriOlusturma
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yaş { get; set; }

        public string KimlikNo { get; set; }

        public string IletisimNo { get; set; }

        public int Cinsiyet { get; set; }

        public int Engelli { get; set; }

        public Musteri musteri()
        {
            Console.Write("Lütfen Adınızı Giriniz: ");
            Ad = Console.ReadLine();

            Console.Write("Lütfen Soyadınızı Giriniz: ");
            Soyad = Console.ReadLine();

            Console.Write("Lütfen Yaşınızı Giriniz: ");
            Yaş = Console.ReadLine();

            Console.Write("Lütfen Kimlik Numaranızı Giriniz: ");
            KimlikNo = Console.ReadLine();

            Console.Write("Lütfen İletişim Numaranızı Başında Sıfır Olmadan Giriniz: ");
            IletisimNo = Console.ReadLine();

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Lütfen Cinsiyetinizi Giriniz (Erkek = E / Kadın = K ): ");
                Temp = Console.ReadLine();

                if (Temp == "E")
                {
                    Cinsiyet = 1;
                    break;
                }
                else if (Temp == "K")
                {
                    Cinsiyet = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Engel Durumunuz Var mı?(Evet = E / Hayır = H): ");
                Temp = Console.ReadLine();

                if (Temp == "E" ) 
                {
                    Engelli = 1;
                    break;
                }
                else if (Temp == "H")
                {
                    Engelli = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            Musteri musteri = new Musteri(Ad, Soyad, Yaş, KimlikNo, IletisimNo, Cinsiyet, Engelli);

            return musteri;
        }
    }
}