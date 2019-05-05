using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetExample
{
    class Musteri
    {
        private string AdSoyad;
        private ulong TCNo;
        private int OdaNo;

        public string adsoyad
        {
            get
            {
                return AdSoyad;
            }
            set
            {
                AdSoyad = value;
            }
        }

        public ulong tcno
        {
            get
            {
                return TCNo;
            }
            set
            {
                if (value.ToString().Length == 11)
                    TCNo = value;
                else
                    Console.WriteLine("HATA! TC Kimlik Numarası 11 Haneli Olmalıdır.");
            }
        }
        public int odano
        {
            get
            {
                return OdaNo;
            }
            set
            {
                if (value > 0 && value <= 120)
                    OdaNo = value;
                else
                    Console.WriteLine("HATA! Oda Numarası 1-120 Aralığında Olmalıdır. ");
            }
        }
    }


}

