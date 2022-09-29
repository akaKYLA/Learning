using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girdiğim_değer_dizide_var_mı__Diziler_pratik_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] rakamlar = { 1, 2, 8, 4, 5, 3, 3, 4, 8, 8, 3, 5, 7 };

            int rakam;
            int adet=0;

            Console.Write("Dizide aramak istediğiniz rakamı giriniz = ");

            rakam = Convert.ToInt32(Console.ReadLine());

            /*for (int i = 0; i < rakamlar.Length; i++)
            {
                if (rakam == rakamlar[i])
                {
                    adet++;
                }
            }*/

            foreach (int a in rakamlar)    //rakamlar dizisinin her bir elamanını a değişkeni olarak tanımladık ve kullanıcının girdiği rakam ile karşılaştırdık.
            {
                if (a==rakam)
                {
                    adet++;
                }
            }

            if (adet==0)
            {
                Console.WriteLine("Aradığınız rakam dizinin içinde bulunamadı...");
            }
            else
            {
                Console.WriteLine("Aradığınız rakam dizinin içinde bulundu...");
                Console.WriteLine("Adet: " + adet);
            }

            Console.ReadLine();
           
        }
    }
}
