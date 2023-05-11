using System;

namespace Gürkan.Kaplan.uçak.rezervasyon.uygulaması
{
    internal class Rezervasyon
    {
        public int ucret;

        Random random = new Random();

        public Rezervasyon()
        {
            ucret = Convert.ToInt32(random.Next(1000, 6500));
        }
    }
}
