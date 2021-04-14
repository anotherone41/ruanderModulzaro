using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("balkezesek.csv");
            List<Jatekos> jatekosok = new List<Jatekos>();
            foreach (string sor in sorok.Skip(1))
            {
                jatekosok.Add(new Jatekos(sor));
            }

            //1. feladat
            int jatekosokSzama = 0;
            foreach (Jatekos jatekos in jatekosok)
            {
                jatekosokSzama++;
            }
            Console.WriteLine($"1. feladat: {jatekosokSzama} versenyzőről van adatunk");




            Console.ReadLine();
        }
    }
}
