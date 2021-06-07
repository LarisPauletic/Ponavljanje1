using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  Brojevi, Zbroj;
            int[] Broj = new int[1];


            Console.Write("Upisite broj : ");
            Brojevi = Convert.ToInt32(Console.ReadLine());

            KlasaG Objekt = new KlasaG();
            Brojevi = Objekt.Plus10(Brojevi) ;
            Zbroj = Objekt.f50(Brojevi);
            Console.WriteLine("Plus10 : " + Brojevi + " f50 : " + Zbroj);

            Console.ReadKey();
        }
    }
}
