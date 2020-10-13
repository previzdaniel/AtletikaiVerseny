using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> atletak = new List<Atleta>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                atletak.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
        }

        static void feladat2()
        {
            Console.WriteLine("2. feladat: Nevek és ugrások\n");
            foreach (var a in atletak)
            {
                Console.WriteLine($"{a.VezNev}\t{a.KerNev}\t{a.Ugras}");
            }
        }

        static void feladat3()
        {

        }

        static void Main(string[] args)
        {
            Beolvas();
            feladat2();
            feladat3();
            //Atleta a = new Atleta("623;Ug Imre;Kalocsai Rozmarok;640");

            Console.ReadKey();
        }
    }
}
