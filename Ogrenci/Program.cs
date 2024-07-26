using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();

            
            
            ogrenci1.setIsim("ESRA");

            string gelenIsim = ogrenci1.getIsim();

            
            
            
            Console.WriteLine(gelenIsim);

            Console.ReadLine();




        }
    }
}
