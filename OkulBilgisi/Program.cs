using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulBilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Okul okul1 = new Okul(220,"ESRA" , "ERBİL" , 12 , 34 , 56 , "ADİLE MERMERCİ LİSESİ");


            bool kontrol = true; 

            

            write();

            while (kontrol)
            {

                string girilenSayi = Console.ReadLine();



                switch (girilenSayi)
                {
                    case "1":

                        okul1.ogrenciBilgileriGoster();
                        break;

                    case "2":

                        okul1.ogrenciOrtalamasıBul();
                        break;

                    case "3":

                        okul1.okulGetir();
                        break;

                    case "4":

                        kontrol = false;
                        break;

                }
            }
            

            Console.ReadLine();

        }
        
        static void write()
        {
            Console.WriteLine("GÖRMEK İSTEDİĞİNİZ NUMARAYA TIKLAYINIZ !\n" +
            "1-ÖĞRENCİ BİLGİLERİ GÖSTER\n" +
            "2-ÖĞRENCİ ORTALAMASINI GÖSTER\n" +
            "3-ÖĞRENCNİN OKULUNU GÖSTER\n" +
            "4-ÇIKIŞ YAP");
        }
  
    }
}
