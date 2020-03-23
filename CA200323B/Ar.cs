using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200323B
{
    class Ar
    {
        public DateTime Valtozas { get; set; }
        public int Benzin { get; set; }
        public int Gazolaj { get; set; }

        public int ArDif => Math.Abs(Benzin - Gazolaj);

        public bool Szokonap => DateTime.IsLeapYear(Valtozas.Year) && Valtozas.Month == 2 && Valtozas.Day == 24;
        public Ar(string s)
        {
            var t = s.Split(';');
            Valtozas = DateTime.Parse(t[0]);
            Benzin = int.Parse(t[1]);
            Gazolaj = int.Parse(t[2]);
        }
    }
}
