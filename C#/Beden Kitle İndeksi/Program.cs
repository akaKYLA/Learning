using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_İndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void bkindeksi()
            {
                Console.WriteLine("Lütfen kilonuzu giriniz (kg) = ");
                double kilo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen boyunuzu giriniz (cm) = ");
                double boy = Convert.ToInt32(Console.ReadLine());
                boy /= 100; // cm cinsinden yazılan boyu m cinsine çevirdik.
                double sonuc = kilo / (boy * boy);


                if (sonuc <= 18)
                {
                    Console.WriteLine("Beden kitle indeksiniz: " + sonuc);
                    Console.WriteLine("AZ EKMEK YE DE KİLO AL AQ");
                }
                else if (18 < sonuc && sonuc < 25)
                {
                    Console.WriteLine("Beden kitle indeksiniz: " + sonuc);
                    Console.WriteLine("ASLANIM BENİM KİLON İYİ BÖYLE DEVAM");
                }
                else if (sonuc >= 25)
                {
                    Console.WriteLine("Beden kitle indeksiniz: " + sonuc);
                    Console.WriteLine("SENİN YÜZÜNDEN AFRİKADAKİLER AÇLIKTAN ÖLÜYOR MK OBEZİ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Tekrar işlem yapmak için 1 yazınız.");
                Console.WriteLine("Programı kapatmak için 2 yazınız.");
                int islem = Convert.ToInt32(Console.ReadLine());

                if (islem == 1)
                {
                    bkindeksi();
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Tekrar görüşmemek dileğiyle");
                    Console.WriteLine("SİKTİR GİT...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz...");
                    bkindeksi();
                }
            }
            Console.WriteLine("Beden Kitle İndeksi Hesaplama Programına Hoşgeldiniz");
            bkindeksi();
        }
    }
}
