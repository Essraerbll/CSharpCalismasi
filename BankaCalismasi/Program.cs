using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaCalismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HOŞGELDİNİZ!!");

            int bakiye = 700;

            



            while (true)
            {
                Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ " +
                    "SAYI İLE GİRER MİSİNİZ?");
                
                string sayi = Console.ReadLine();

                if (sayi == "1")
                {
                    Console.WriteLine(sayi + " => SEÇTİNİZ BU " +
                        "PARA YATIRMA İŞLEMİ");
                    break;
                }

                else if (sayi == "2")

                {
                    Console.WriteLine(sayi + " => SEÇTİNİZ BU " +
                        "PARA ÇEKME İŞLEMİ");

                    while (true)
                    {

                        Console.WriteLine("ÇEKMEK İSTEDİĞİNİZ " +
                            "TUTARI GİRER MİSİNİZ?");

                        int girilenTutar =
                            Convert.ToInt32(Console.ReadLine());

                        if (girilenTutar > 700)
                        {
                            Console.WriteLine("Girilen Bakiye = " +
                                girilenTutar +
                                " => Bakiyenizden fazla para" +
                                "çekemezsiniz!!");

                        }
                        else if (girilenTutar <= 700)
                        {
                            Console.WriteLine("Para Çekme İşleminiz " +
                                "Yapılıyooorrrr!!");

                            break;

                        }
                    }
                    break; 
                    
                }

                else if (sayi == "3")

                {
                    Console.WriteLine(sayi + " => SEÇTİNİZ BU " +
                        "KREDİ KARTI İŞLEMİ");
                    break;
                }
                else
                {
                    Console.WriteLine("İŞLEM GEÇERSİZDİR!!");
                }
            }

            Console.ReadLine();




        }
    }
}
