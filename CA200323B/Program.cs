using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA200323B
{
    class Program
    {
        static List<Ar> arak;
        static int minDif;
        static void Main()
        {
            Beolvas();
            F03();
            F04();
            F05();
            F06();

            Console.ReadKey();
        }

        private static void F06()
        {
            bool van = arak.Any(a => a.Szokonap);

            //bool van = arak.Any(
            //    a => DateTime.IsLeapYear(a.Valtozas.Year)
            //    && a.Valtozas.Month == 2
            //    && a.Valtozas.Day == 24);

            Console.WriteLine($"f6: {(van ? "van" : "nincs")} szökőnapon változás");
        }

        private static void F05()
        {
            int db = arak.Count(a => a.ArDif == minDif);
            Console.WriteLine($"f5: {db}");

            //int db = arak.Count(a => Math.Abs(a.Benzin - a.Gazolaj) == arak.Min(b => Math.Abs(b.Gazolaj - b.Benzin)));
            //Console.WriteLine($"f5: {db}");
        }

        private static void F04()
        {
            //m0

            //var m = 0;

            //for (int i = 1; i < arak.Count; i++)
            //{
            //    if (Math.Abs(arak[i].Benzin - arak[i].Gazolaj) < Math.Abs(arak[m].Benzin - arak[m].Gazolaj))
            //        m = i;
            //}
            //Console.WriteLine($"f4: {Math.Abs(arak[m].Benzin - arak[m].Gazolaj)}");

            //m0.1
            //var m = 0;
            //for (int i = 1; i < arak.Count; i++)
            //{
            //    if (arak[i].ArDif < arak[m].ArDif) m = i;
            //}
            //Console.WriteLine($"f4: {arak[m].ArDif}");


            //m1
            minDif = arak.Min(a => a.ArDif);
            Console.WriteLine($"f4: {minDif}");

            //m2
            //var m = arak.Min(a => Math.Abs(a.Benzin - a.Gazolaj));
            //Console.WriteLine($"f4: {m}");
        }

        private static void F03()
        {
            Console.WriteLine($"sorok szama: {arak.Count}");
        }

        private static void Beolvas()
        {
            arak = new List<Ar>();
            var sr = new StreamReader(@"..\..\Res\uzemanyag.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
                arak.Add(new Ar(sr.ReadLine()));
            sr.Close();
        }
    }
}
