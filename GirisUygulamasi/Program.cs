using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("KULLANICI ADINIZI GİRİNİZ : ");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("ŞİFRENİZİ GİRİNİZ : ");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == "Esra" && sifre == "123")
                {
                    Console.WriteLine("TEBRİKLER BAŞARILI BİR GİRİŞ YAPTINIZ :) ");
                    break;
                }
                else
                {
                    Console.WriteLine("YANLIŞ GİRİŞ YAPTINIZ!!TEKRAR DENEYİNİZ");
                    
                    if (hak_sayisi > 0)
                    {
                        hak_sayisi--;

                    }
                    if (hak_sayisi == 0)
                    {
                        Console.WriteLine("GİRİŞ HAKKINIZ DOLMUŞTUR");
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
