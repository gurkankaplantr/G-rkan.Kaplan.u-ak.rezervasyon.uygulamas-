using Gürkan.Kaplan.uçak.rezervasyon.uygulaması;
using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class UcakOlusturma : IUcak
    {
        public string Model { get; set; }
        public string SeriNo { get; set; }

        public int YolcuKapasitesi { get; set; }

        public string BagajKapasitesi { get; set; }

        public int Hiz { get; set; }

        private Random Random = new Random();

        public UcakOlusturma()
        {
            int random = Random.Next(0, 5);

            switch (random)
            {
                case 0:
                    Model = "BOİNG711";
                    SeriNo = "AZ784578";
                    YolcuKapasitesi = 220;
                    BagajKapasitesi = "25 KG";
                    Hiz = 800;
                    break;

                case 1:
                    Model = "BOİNG A300";
                    SeriNo = "DR456784";
                    YolcuKapasitesi = 350;
                    BagajKapasitesi = "20 KG";
                    Hiz = 830;
                    break;

                case 2:
                    Model = "BOİNG 787";
                    SeriNo = "ŞÜ821478";
                    YolcuKapasitesi = 300;
                    BagajKapasitesi = "15 KG" ;
                    Hiz = 900;
                    break;

                case 3:
                    Model = "ATR 72";
                    SeriNo = "KR145678";
                    YolcuKapasitesi = 240;
                    BagajKapasitesi =  "15 KG"  ;
                    Hiz = 1560;
                    break;
                case 4:
                    Model = "AERO 10 S";
                    SeriNo = "THY478147";
                    YolcuKapasitesi= 350;
                    BagajKapasitesi = "10 KG";
                    Hiz = 1200;
                    break;

                default:
                    break;
            }
        }
    }
}