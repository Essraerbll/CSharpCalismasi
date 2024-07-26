using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kilo kilo1 = new Kilo();


            kilo1.Weight = 85;

            
            
            Console.WriteLine(kilo1.Weight);

            
            Console.ReadLine();


        }
    }
}
