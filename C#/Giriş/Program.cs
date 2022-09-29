using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WriteLine ile alt alta yazılabilir.                              ---------------GİRİŞ---------------
            // Write ile aynı satıra yazılır.

            Console.WriteLine("Hello Baby");
            Console.Write("Kadir ");
            Console.Write("Secgil");
            Console.ReadLine();

            //                                                          ---------------KULLANICIDAN DEĞER ALMA---------------
            //
            // Eğer bir değişkene READLİNE fonksiyonu yazarsak o değişkenin değeri, kullanıcıdan alınan girdi ile oluşturulur. READLİNE STRİNG DEĞER DÖNER.


            Console.Write("Lütfen adınızı giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soy adınızı giriniz: ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi: " + isim + " " + soyisim);
            Console.ReadLine();

            /* 
             *                                                                 ---------------OPERATÖRLER---------------
             * 
                          ARİTMETİK OPERATÖRLER
            + = Toplama
            - = Çıkarma
            * = Çarpma
            / = Bölme
            % = Kalan bulma
            -- = Değeri bir azaltır
            ++ = Değeri bir arttırır.
            = = Değerleri birbirine aktarır.

                         KARŞILAŞTIRMA OPERATÖRLERİ
            >  = Büyüktür
            >= = Büyük eşit
            <  = Küçüktür
            <= = Küçük eşit
            == = Eşittir
            != = Farklıdır
                         
                         MANTIKSAL OPERATÖRLER
            && = ve (and)
            || = veya (or)
            !  = değil

                         EK OPERATÖRLER
            += == "a += 4" a değerine 4 ekler. Sonuç yeni a değeri olur. Örn: a = 5 --> a += 4 denildiği zaman a nın yeni değeri 9 olur.
            -= == üsteki açıklamanın çıkarma işlemi şekli.
            /= == üsteki açıklamanın bölme işlemi şekli.
            *= == üsteki açıklamanın çarpma işlemi şekli.
            
            */
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("4 İşlem ");
            Console.WriteLine("");
            Console.WriteLine("10 + 20 = " + (sayi1 + sayi2));
            Console.WriteLine("10 - 20 = " + (sayi1 - sayi2));
            Console.WriteLine("20 / 10 = " + (sayi2 / sayi1));
            Console.WriteLine("10 * 20 = " + (sayi1 * sayi2));
            Console.WriteLine("20 / 10 işleminden kalan = " + (sayi2 % sayi1));

            Console.ReadLine();

            /*
             *                                                                 ---------------VERİ TİPLERİ---------------
             * 
            byte = 1-255 arası tam sayılar (1byte)
            short = 1-32000 arası değerler (2byte)
            int = 10 basamağa kadar oluşan tam sayıları kapsar (4byte)
            long = 18,19 basamağa kadar çıkan tam sayılar (8byte)
            float = ondalıklı sayıları tanımlar (2byte)
            double = çok büyük ondalıklı sayıları tanımlar (4byte)
            bool (boolean) = True veya False olarak değer alır. (2byte)
            char = TEK bir karakter tutmak için kullanılır.
            string = metinleri tanımlamak için kullanılır 
            object = TÜM VERİ TİPLERİNİ TANIMLAMAK İÇİN KULLANILIR.
            */
            byte birinci = 255;
            short ikinci = 18666;
            int ücüncü = 1234567890;
            long dördüncü = 1234567890123456789;
            float besinci = 16.2f; //Float veri tipi tanımlarken sayının sonuna f eklenir. Böylece double olarak tanımlanmaz.
            double altinci = 36.5;
            bool yedinci = 18 < 25;
            bool yedinci2 = 18 > 25;
            char sekizinci = 'c'; //char tanımlanırken çift tırnak yerine tek tırnak kullanılır.
            string dokuzuncu = "Kadir Secgil";
            /*
            Değişken adaları sayı ile başlayamazlar. ("int 1sayi")
            Değişken adlarında boşluk kullanılmaz. ("double ondalikli sayi")
            Türkçe karakter kullanılmaz.  ("int sayı")
            */

            Console.WriteLine("BYTE veri tipi = " + birinci);
            Console.WriteLine("SHORT veri tipi = " + ikinci);
            Console.WriteLine("İNT veri tipi = " + ücüncü);
            Console.WriteLine("LONG veri tipi = " + dördüncü);
            Console.WriteLine("FLOAT veri tipi = " + besinci);
            Console.WriteLine("DOUBLE veri tipi = " + altinci);
            Console.Write("BOOLEAN veri tipi = 18 < 25 = " + yedinci);
            Console.WriteLine(" veya 18 > 25 = " + yedinci2);
            Console.WriteLine("CHAR veri tipi = " + sekizinci);
            Console.WriteLine("STRİNG veri tipi = " + dokuzuncu);
            Console.ReadLine();

            /*
             *                                                                  ---------------TÜRLER ARASI DÖNÜŞÜMLER---------------
             * 
                           Farklı Değişken ---> İnt

                int.Parse("dönüştürülmek istenen değişken") == Sadece String --> İnt için geçerli fonksiyon.

               *** Convert.ToInt32("dönüştürülmek istenen değişken")

                            Farklı Değişken ---> String

               *** dönüştürülmek_istenen_değişken.ToString()
               

                 Değiştirilen değişkeni, ilgili değişken sınıfına atamanız gerekir.
            Örn:

            string a = "3"
            int b = Convert.ToInt32(a) ----->>>>  İnt olan b değişkenine değer olarak, a string değişkeninin int e dönüştürülmüş halini atadık.

            */

            /*                                                                  ---------------DİZİLER (ARRAY)---------------
                                                                            
            int[] sayilar = new int[4];  --->>>> sayilar adında 4 adet değişken tutabilen bir int dizisi oluşturduk. Her türlü değişken için dizi oluşturulabilir.
            int[] sayilar = {10,20,30,40}; ---->>>> direkt olarak değişkenleri atayabiliriz.

            sayilar[0] = 10;
            sayilar[1] = 20;             --->>>> sayilar dizisinin her bir indexine değer atadık.
            sayilar[2] = 30;
            sayilar[3] = 40;

                
                                                                                 ---------------FOREACH DÖNGÜSÜ---------------

            string[] isimler = {"Kadir","Enes","Sercan","Küçükköy"};

            foreach (string a in isimler)     --->>>> Dizilerde kullanılan bir for döngüsüdür. Belirttiğiniz işlemi her index için uygular.
            {
                Console.WriteLine(a);
            
            }


                                                                                 ---------------METHODLAR---------------

                       Parametre almayan ve geriye değer döndürmeyen method --->>>> " void methodadı() "

            static void selamver()
            {
                Console.WriteLine("Selamlar");      ---->>> selamver() ekrana selamlar yazdıran method
            }

                       Parametreli method ---->>>> void methodadı(int parametreadı,string parametreadı....)

            static void toplamayap(int sayi1,int sayi2)
            {
                Console.WriteLine("Gönderilen Sayların Toplamı: " + (sayi1+sayi2)); ----->>>> sayi1 ve sayi2 parametresi alıp birbiriyle toplayan method
            }

                       Değer döndüren method --->>> static int toplamayap(int sayi1,int sayi2) int formatında değer döndüren method

            int dönendeğer = toplamayap(6,7); ---->>>> iki sayıyı doplayıp int olan dönendeğer değişkenine atar.

            static int toplamayap(int sayi1,int sayi2)
            {
                int sonuc = sayi1 + sayi2;

                return sonuc;   ---->>> methodun çağırıldığı yere değeri döndürür. Ve methodu bitirir. Sonrasında method içine yazılan kodlar geçersizdir.
            }

            Yapıcı Methodlar ---->>>>>  Classlardan obje oluşturduğumuz sırada oluşan, geriye dönüş tipi olmayan methodlardır.

            public class Araba{ 

                public Araba() ---->>>> Class ismi ile aynı olmalıdır. Geriye dönüş tipi(void,int,string...) yoktur. Parantez içine parametre alabilir (yapıcı method içinde değişken var ise). 
                {
                    //Araba classının yapıcı methodu içerisindeyiz.                                     ctor yazıp tabtab yapılırsa direkt oluşturulur.
                }

            Araba araba1 =new Araba(); ---->>>> Araba classının içindeki Araba() yapıcı methodunu çalıştırır. Daha sonra o class dan bir obje oluşturur.

            }


                                                                                 ---------------CLASSLAR---------------


            Classlar değişkenlerimizi ve methodlarımı içinde tutan container'dır.

            Örneğin araba adında bir class oluşturup içine:

                Kapı sayısı değişkeni
                Araba rengi değişkeni
                        ve
                Kapıları kilitle methodu
                Motoru çalıştır methodu
                                           yerleştirebiliriz.

            public class Araba{ --->> class başlangıç tırnağı

                public int kapisayisi;
                public string arabarengi;
                
                public void kapilarikilitle()
                {                                     class verileri...
                    //kodlar//
                }

                public void motoruçalıştır()
                {
                    //kodlar//
                }
            }----> class bitiş tırnağı




            */
        }
    }
}
