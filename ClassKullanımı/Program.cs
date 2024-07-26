using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araba araba1 = new Araba();

            
            araba1.motorCalistir();

            
            
            araba1.kapiSayisi = 4;

            araba1.arabaRengi = "KIRMIZI";

            araba1.arabaModeli = "RENAULT";


            

            Console.WriteLine("ARABANIN KAPI SAYISI = " + araba1.kapiSayisi);

            Console.WriteLine("ARABANIN RENGİ = " + araba1.arabaRengi);

            Console.WriteLine("ARABANIN MODELİ = " + araba1.arabaModeli);


           
            araba1.kapilariKilitle();


           
            
            Console.ReadLine();
        }
    }
}
