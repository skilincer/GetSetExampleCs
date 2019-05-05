using System;

namespace GetSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.adsoyad = "İsim Soyisim";  // adsoyad özelliğinin SET metodu çalıştı.
            m1.tcno = 12345678912;         // tcno özelliğinin SET metodu çalıştı.
            m1.odano = 110;                // odano özelliğinin SET metodu çalıştı.

            // adsoyad, tcno ve odano özelliklerinin GET metodu çalıştı. 
            Console.WriteLine("Ad/Soyad:{0} - Tc No:{1} - Oda No:{2}", m1.adsoyad, m1.tcno, m1.odano);
            /*
                 
                        Sınıfın AdSoyad, TCNo, OdaNo üyelerini diğer sınıfların erişimine kapattık(private) 
                        ve bu üyelere olan erişimi adsoyad, tcno, odano özellikleri üzerinden kontrollü bir şekilde sağladık.
                        GET Metodu
                        Bir özelliğin değeri okunmak istenildiğinde o özelliğe ait GET metodu çalışır.
                        Console.WriteLine(m1.adsoyad);
                        m1 nesnesinin içerisindeki adsoyad özelliğinin Get metodu çalışacaktır.

                        SET Metodu
                        Bir özelliğe atama yapılmak istenildiğinde o özelliğe ait SET metodu çalışır. 
                        Atanan değere SET metodu içerisinde value anahtar sözcüğü ile erişilir.
                        value anahtar sözcüğünün önceden belirlenmiş herhangi bir türü yoktur.
                        Özelliğe atanacak değer hangi türden ise value da o türden olur.
                        m1.adsoyad=”isim Soyisim”;
                        m1 nesnesinin içerisindeki adsoyad özelliğinin SET metodu çalışacaktır ve value ifadesi “isim soyisim” değerini alacaktır.
                        Bir özelliğin sadece GET metodunu tanımlayarak özelliği sadece okunabilir hale getirebiliriz.
   

            Erişim Belirleyicisi Kullanımı
            GET ve SET metotlarında erişim belirleyicilerini kullanarak erişimin sınırlarını belirtebiliriz.

            C#
            private string AdSoyad;
            public string adsoyad
                
            get
            {
            return AdSoyad;
            }
            private set
            {
            AdSoyad = value;
            }
            }


            private string AdSoyad;
     
            public string adsoyad
            {
              get
                 {
                    return AdSoyad;
                 }
             private set
                {
                    AdSoyad = value;
                }
             }
            Yukarıdaki örneğimizde SET metodu private olarak bildirildi.
            Bu yüzden diğer sınıflardan adsoyad özelliğinin değeri okunabilir ancak herhangi bir atama yapılamaz
            (set metoduna sadece sınıfın içinden erişilebilir).
            Eğer SET metodunu private olarak bildirmeseydik; adsoyad özelliği public olduğu için SET metodu da otomatikmen public olacaktı.

            GET ve SET metotları için herhangi bir erişim belirteci bildirilmezse,
            varsayılan olarak özelliğin erişim belirtecini alırlar.
                */

            // https://www.srdrylmz.com/c-set-ve-get-metotlari/



        }
    }
}
