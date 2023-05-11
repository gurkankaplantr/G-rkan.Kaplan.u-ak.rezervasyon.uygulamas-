using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal interface ILokasyon
    {
        string Ulke { get; set; }

        string Sehir { get; set; }

        string Havalimanı { get; set; }
    }
}