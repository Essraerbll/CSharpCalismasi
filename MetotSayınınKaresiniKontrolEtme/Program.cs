using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotSayınınKaresiniKontrolEtme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sonuç = Karesi();

            if (sonuç > 25)
            {
                Console.WriteLine("KARESİ 25 ' TEN BÜYÜKTÜR");
            }
            
            else if(sonuç ==25) 
            {

                Console.WriteLine("KARESİ 25 ' E EŞİTTİR");
            }
            else
            {
                Console.WriteLine("KARESİ 25 ' TEN KÜÇÜKTÜR");
            }



            Console.ReadLine();

        }

        static int Karesi()
        {

            Console.WriteLine("BİR SAYI GİRİNİZ = ");

            int x = Convert.ToInt16(Console.ReadLine());

            int karesi = x * x;

            return karesi;

        }
    }
}
