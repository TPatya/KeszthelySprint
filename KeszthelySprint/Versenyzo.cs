using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    internal class Versenyzo
    {
        public string Nev { get; set; }

        public int Szuletes { get; set; }

        public int Rajtszam { get; set; }

        public string Gender { get; set; }

        public string Kategoria { get; set; }

        public string uszas { get; set; }

        public string elsodepo { get; set; }

        public string kerekpar { get; set; }

        public string masodikdepo { get; set; }

        public string futas { get; set; }



        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];

            Szuletes = int.Parse(s[1]);

            Rajtszam = int.Parse(s[2]);

            Gender = s[3];

            Kategoria = s[4];

            uszas = s[5];

            elsodepo = s[6];

            kerekpar = s[7];

            masodikdepo = s[8];

            futas = s[9];


        }
    }
}
