using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string X = İsim("ESRA", "ERBİL");
            Console.WriteLine(X);

           
            int x = Topla(6,7);
            Console.WriteLine(x);
            if (x > 10)
            {
                Console.WriteLine("10dan büyük");
            }
             
            else
            {
                Console.WriteLine("10dan küçük");

            }

            Console.ReadLine();

        }


        static string İsim(string isim, string soyisim)
        {

            return isim + " " + soyisim;
        }
        

        static int Topla(int sayi1, int sayi2)
        {

            int x = sayi1 + sayi2;
            
            return x;
        }
        
        
    }


}
