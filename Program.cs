using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra_na_karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0, broj;
            while(zbroj < 31)
            {
                Console.WriteLine("Upisi te vrijednost karte: ");
                broj = Convert.ToInt32(Console.ReadLine());
                if(broj >=1 && broj <= 13)
                {
                    zbroj += broj;
                }
            }
            if(zbroj == 31)
            {
                Console.WriteLine("Pobjedili ste!");
            }
            else
            {
                Console.WriteLine("Izgubili ste");
            }
            Console.ReadKey();
        }
    }
}
