using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Personel
    {

        private string tckimlikno;

        public string TCKİMLİKNO
        {

            get
            {
                return "******" + tckimlikno.Substring(6,5); 
            }

            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {

                    for (int i = 0; i < value.Length; i++)
                    {

                        bool sayiMi = char.IsNumber(value[i]);


                        if (sayiMi)
                        {
                            //YAPMAM GEREKEN BİR ŞEY YOK 

                        }
                       
                        else
                        {

                            kontrol = true;
                            break;
                        }
                    }

                    if(kontrol)
                    {

                        Console.WriteLine("TC'DE GEÇERSİZ KARAKTER VAR!!");
                       
                    }
                    
                    
                    else
                    {

                        tckimlikno = value;
                        
                    }
               
                }
                
                
                else
                {

                    Console.WriteLine("LÜTFEN 11 KARAKTERLİ BİR TC NUMARASI GİRİNİZ!!");
                   
                }

            }
        }



    }
}
