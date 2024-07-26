using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personel P1 = new Personel();
      
            P1.TCKİMLİKNO = "42f88816210";

            Console.WriteLine("TC KİMLİK NUMARANIZ = " + P1.TCKİMLİKNO);

            Console.ReadLine();
        }
    }
}
