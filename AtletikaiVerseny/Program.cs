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
            List<string> egyesuletek = new List<string>();
            Console.WriteLine("\n3. feladat: Egyesületek:\n");
            foreach (var a in atletak)
            {
                if (!egyesuletek.Contains(a.Egyesulet))
                {
                    egyesuletek.Add(a.Egyesulet);
                }
            }
            for (int i = 0; i < egyesuletek.Count; i++)
            {
                Console.WriteLine(egyesuletek[i]);
            }
        }

        static void feladat4()
        {
            Console.WriteLine("\n4. feladat: Legnagyobb ugrás:");
            int max = 0;
            foreach (var a in atletak)
            {
                if (a.Ugras > max)
                {
                    max = a.Ugras;
                }
            }

            foreach (var a in atletak)
            {
                if (max == a.Ugras)
                {
                    Console.WriteLine(a.TeljesNev + " " + a.Ugras);
                }
            }
        }

        static void feladat5()
        {
            int osszes = 0;
            foreach (var a in atletak)
            {
                osszes += a.Ugras;
            }
            double atlag = osszes / atletak.Count;
            int db = 0;
            foreach (var a in atletak)
            {
                if (a.Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine("\n5. feladat: Az átlag alatti ugrások száma: {0}",db);
        }

        static void feladat6()
        {
            Console.WriteLine("6. feladat: adatok fájlba írása");
            StreamWriter file = new StreamWriter("versenyzok.txt");
            for (int i = 0; i < atletak.Count; i++)
            {
                file.WriteLine(atletak[i].Rajtszam + ";" + atletak[i].TeljesNev);
            }
            file.Close();
        }

        static void Main(string[] args)
        {
            Beolvas();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();

            Console.ReadKey();
        }
    }
}
