using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar, baza, baza2, numarschimbat;
            Console.WriteLine("Introdu numarul:");
            numar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In ce baza este numarul?:");
            baza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In ce baza doresti numarul?:");
            baza2 = Convert.ToInt32(Console.ReadLine());
            numarschimbat = din0in10(numar, baza);
            Console.WriteLine("Numarul in baza 10 este: {0}", numarschimbat);
            Console.WriteLine("Numarul in baza {0} este: {1}", baza2, din10in0(numarschimbat, baza2));

        }


        //Conversia din baza oricare -> 10
        static int din0in10(int numar, int baza)
        {
            int numarderezerva = numar;
            int rezultat = 0;
            int ultimacifra;
            int c = 0;
            while (numarderezerva != 0)
            {
                numarderezerva = numarderezerva / 10;
                c++;
            }
            numarderezerva = numar;
            for (int i = 0; i <= c; i++)
            {
                ultimacifra = numarderezerva % 10;
                rezultat = Convert.ToInt32(rezultat + (Math.Pow(baza, i) * ultimacifra));
                numarderezerva = numarderezerva / 10;

            }
            return rezultat;
        }

        //Conversia din baza 10 in oricare
        static int din10in0(int numar, int baza)
        {
            int numarderezerva = numar;
            int ultimacifra, intors = 0, reintors = 0;
            while (numarderezerva != 0)
            {
                ultimacifra = numarderezerva % baza;
                intors = intors * 10 + ultimacifra;
                numarderezerva = numarderezerva / baza;
            }
            while (intors != 0)
            {
                ultimacifra = intors % 10;
                reintors = reintors * 10 + ultimacifra;
                intors = intors / 10;
            }
            return reintors;
        }
    }
}

namespace crap
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numar, numar2, zecimal, zecimal2, salvat;
            int c = 0;
            int ultimacifra;
            numar = 32.625m;
            numar2 = Convert.ToInt32(numar);
            salvat = numar;
            zecimal = numar - numar2;
            while (zecimal != 0)
            {
                zecimal = zecimal * 10;
                c++;
                zecimal2 = Convert.ToInt32(zecimal);
                zecimal = zecimal - zecimal2;
            }
            Console.WriteLine(c);
            //Console.WriteLine(numar-numar2);

        }
    }
}
