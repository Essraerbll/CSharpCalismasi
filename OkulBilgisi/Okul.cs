using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulBilgisi
{
    public class Okul
    {

        private int ogrenciNo;

        private string ogrenciAdı;

        private string ogrenciSoyadı;

        private double vize1;

        private double vize2;

        private double final;

        private string okulAdı;

       

        public Okul(int _ogrenciNo , string _ogrenciAdı , string _ogrenciSoyadı , double _vize1 , double _vize2 , 
            double _final , string _okulAdı)
        {

            ogrenciNo = _ogrenciNo ;
            ogrenciAdı =  _ogrenciAdı;
            ogrenciSoyadı = _ogrenciSoyadı ;
            vize1 = _vize1;
            vize2 = _vize2 ;
            final = _final; 
            okulAdı = _okulAdı;


        }
       
         
        public void ogrenciBilgileriGoster()
        {


            Console.WriteLine("ÖĞRENCİNİN NUMARASI = "+ogrenciNo);

            Console.WriteLine("ÖĞRENCİNİN ADI = " + ogrenciAdı);

            Console.WriteLine("ÖĞRENCİNİN SOYADI = " + ogrenciSoyadı);

            Console.WriteLine("VİZE 1 = " + vize1);

            Console.WriteLine("VİZE 2 = " + vize2);

            Console.WriteLine("FİNAL =  " + final);

            Console.WriteLine("OKUL ADI = " + okulAdı);

        }         

        public void ogrenciOrtalamasıBul()
        {
            double ortalama = ((vize1 + vize2) / 2 * (0.4)) 
                
                + ((final * 0.6));

            Console.WriteLine("NOT ORTALAMASI = " + ortalama);


        }

        public void okulGetir()
        {

            Console.WriteLine("OKUL ADI =  " + okulAdı);

        }
    }
}
