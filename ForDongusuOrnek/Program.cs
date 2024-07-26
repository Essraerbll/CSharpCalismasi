using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BİR SAYI GİRİNİZ = ");

            float girilenSayi = Convert.ToInt16(Console.ReadLine());
            
            float i = 0;
            
            for(float a = 0; a <=girilenSayi; a++)
            {
                i += a;
            }

            Console.WriteLine("0'DAN GİRİLEN SAYIYA KADAR OLAN SAYILARIN TOPLAMI   = " + i);

            float sonuc = i / girilenSayi;
           
            Console.WriteLine("ORTALAMA = " + sonuc);

            if (sonuc >50)
            {
                Console.WriteLine("ORTALAMA 50'DEN BÜYÜKTÜR");

            }
            else if (sonuc == 50)
            {

                Console.WriteLine("ORTALAMA 50'DİR");
            }
            else
            {
                Console.WriteLine("ORTALAMA 50'DEN KÜÇÜKTÜR");
            }
            Console.ReadLine();
        }
    }
}
