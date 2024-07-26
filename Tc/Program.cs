using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Tc tc1 = new Tc();


            tc1.setTc(234);

            
            
            int kişininTcsi = tc1.getTc();

            
            
            
            Console.WriteLine(kişininTcsi);


            Console.ReadLine();




        }
    }
}
