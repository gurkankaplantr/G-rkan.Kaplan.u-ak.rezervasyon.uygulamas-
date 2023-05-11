using System;
using System.Threading;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "UÇAK REZERVASYON SİSTEMİ";
            Console.WriteLine("###########################################################");
            Console.WriteLine("KURUMUMUZ TÜRK HAVA YOLLARI TARAFINDAN FİNANSE EDİLMEKTEDİR");
            Console.WriteLine("###########################################################\n");
            Console.WriteLine("######################################################");
            Console.WriteLine("SAYIN YOLCUMUZ UÇAK REZERVASYON SİSTEMİNE HOŞGELDİNİZ.");
            Console.WriteLine("######################################################\n");
            Console.WriteLine("##############################################");
            Console.WriteLine("KURUMUMUZ %100 BİLGİ GÜVENLİĞİ SAĞLAMAKTADIR.");
            Console.WriteLine("##############################################\n");
            MusteriOlusturma musteriOLusturma = new MusteriOlusturma();
            Musteri musteri = musteriOLusturma.musteri();

            UcusOlusturma ucusOlusturma = new UcusOlusturma(musteri.Ad, musteri.Soyad);
            Console.Write(ucusOlusturma.UcusDondur());
            Console.Write("\n\n########################################");
            Console.Write("\n SAYIN YOLCUMUZ İYİ UÇUŞLAR DİLERİM.\n");
            Console.Write("###########################################\n");

            Thread.Sleep(1000);
        }
    }
}