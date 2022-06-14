using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Classlar
{
    class Formatlar
    {
        public string IngilizceTarihFormati(string GelenTarih)
        {
            DateTime Tarih = Convert.ToDateTime(GelenTarih);
            string Gun, Ay, Yil, Saat, Dakika, Saniye;
            Gun = Tarih.Day.ToString();
            Ay = Tarih.Month.ToString();
            Yil = Tarih.Year.ToString();
            Saat = Tarih.Hour.ToString();
            Dakika = Tarih.Minute.ToString();
            Saniye = Tarih.Second.ToString();

            string YeniTarih = Ay + "." + Gun + "." + Yil + " " + Saat + ":" + Dakika + ":" + Saniye;
            return YeniTarih;
        }
    }
}
