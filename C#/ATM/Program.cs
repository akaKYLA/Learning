using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;

            Console.WriteLine("ATM ' ye hoşgeldiniz");
            Console.WriteLine("");
            Console.WriteLine("Bakiye sorgulamak için --> 1");
            Console.WriteLine("Para çekmek için --> 2");
            Console.WriteLine("Para yatırmak için--> 3");
            Console.WriteLine("");
            Console.WriteLine("Uygulamadan çıkmak için --> q");
            Console.WriteLine("");

            

            /*
             
            1 = Bakiye sorgulama
            2 = Para Çekme
            3 = Para Yatırma
            q = Uygulamadan çıkış
            
            */

            void islem()

            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz. ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine(bakiye);
                    islem();
                }

                else if (secim == "2")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                    int ctutar = Convert.ToInt32(Console.ReadLine());
                    if (bakiye>ctutar)
                    {
                        bakiye -= ctutar;
                        Console.WriteLine("Para çekme işleminiz tamamlandı.");
                        Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                        islem();
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.");
                        bakiye += 0;
                        islem();
                    }
                    
                }

                else if (secim == "3")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                    int ytutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += ytutar;

                    Console.WriteLine("Para yatırma işleminiz tamamlandı.");
                    Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                    islem();
                }

                else if (secim == "q")
                {
                    Console.WriteLine("Uygulamadan çıkılıyor.");
                    Console.WriteLine("İyi günler dileriz...");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                    islem();
                }

            }
            islem();
            Console.ReadLine();

            
        }
    }
}
