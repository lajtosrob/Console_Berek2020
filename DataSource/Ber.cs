using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Berek2020.DataSource
{
    internal class Ber
    {

        string nev;
        string neme;
        string reszleg;
        int belepesEve;
        double fizetes;

        public Ber(string nev, string neme, string reszleg, int belepesEve, double fizetes)
        {
            this.nev = nev;
            this.neme = neme;
            this.reszleg = reszleg;
            this.belepesEve = belepesEve;
            this.fizetes = fizetes;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Neme { get => neme; set => neme = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int BelepesEve { get => belepesEve; set => belepesEve = value; }
        public double Fizetes { get => fizetes; set => fizetes = value; }
    }
}
