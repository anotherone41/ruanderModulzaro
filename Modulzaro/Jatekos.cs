using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Jatekos
    {
        public string nev  { get; set; }
        public string elso { get; set; }
        public string utolso { get; set; }
        public double suly { get; set; }
        public double magassag { get; set; }

        public Jatekos(string sor)
        {
            string[] sorok = sor.Split(';');
            nev = sorok[0];
            elso = sorok[1];
            utolso = sorok[2];
            suly = double.Parse(sorok[3]);
            magassag = double.Parse(sorok[4]);
        }
    }
}
