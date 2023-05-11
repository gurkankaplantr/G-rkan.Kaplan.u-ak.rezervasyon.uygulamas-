using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal interface IUcak
    {
        public string Model { get; set; }

        public string SeriNo { get; set; }

        public int YolcuKapasitesi { get; set; }

        public string BagajKapasitesi { get; set; }

        public int Hiz { get; set; }
    }
}