using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar= new int[10];

            int ciftToplam = 0;

            int ciftSayi = 0;
           
            int tekToplam = 0;

            int tekSayi = 0;


            
            for (int i = 0; i < sayilar.Length; i++)
            {

                Console.Write("BİR SAYI GİRİNİZ = ");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());


                if (sayilar[i] % 2 == 0)
                {
                    ciftSayi++;
                    ciftToplam += sayilar[i];
                }
                else if (sayilar[i] % 2 == 1)
                {
                    tekSayi++;
                    tekToplam += sayilar[i];
                }


            }
            Console.WriteLine("ÇİFT SAYILAR " + ciftSayi +" TANE");

            Console.WriteLine("TEK SAYILAR " + tekSayi + " TANE");

            if (ciftToplam < tekToplam)
            {
                Console.WriteLine("TEK SAYILARIN TOPLAMI ÇİFT SAYILARIN TOPLAMINDAN BÜYÜKTÜR :)))");
            
            
            }else if (tekToplam < ciftToplam){

                Console.WriteLine("ÇİFT SAYILARIN TOPLAMI TEK SAYILARIN TOPLAMINDAN BÜYÜKTÜR :(((");
            }
            
            

            Console.ReadLine();


        }




    }
}
