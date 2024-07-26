using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = {10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65,
            5, 20, 35, 65, 5, 20, 35, 65, 80};

            Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ : ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GİRDİĞİNİZ SAYİ = " + sayi);

            int toplamKac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {

                if (sayilar[i] == sayi)
                {
                    toplamKac++;
                }
            }
            if (toplamKac == 0)
            {
                Console.WriteLine("GİRDİĞİNİZ SAYI BULUNAMADI");
            }
            else
            {
                Console.WriteLine("DİZİMİZ GİRDİĞİNİZ SAYIYI " + toplamKac +" KERE İÇERİYOR :)");
            }
            
            Console.ReadLine();
        }
    }
}
