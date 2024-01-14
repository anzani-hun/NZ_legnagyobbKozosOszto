using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_legnagyobbKozosOszto
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Két számnak a legnagyobb közös osztója!");

            int szam1, szam2;

            Console.Write("Kérem az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            //függvény meghívása
            LegnagyobbKozosOszto(szam1, szam2);

            Console.WriteLine($"{szam1} és {szam2} legnagyobb közös osztója: {LegnagyobbKozosOszto(szam1, szam2)}");

            Console.ReadKey();
        }

        static int LegnagyobbKozosOszto(int a, int b)
        {
            int maradek;

            while ( b != 0 )
            {
                maradek = a % b;
                a = b;
                b = maradek;
            }
            return a;

        }
    }
}
