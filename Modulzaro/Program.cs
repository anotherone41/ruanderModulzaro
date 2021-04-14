﻿using System;
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

            //2. feladat
            Console.WriteLine("2. feladat:");
            List<Jatekos> elso1980 = new List<Jatekos>();
            foreach (Jatekos jatekos in jatekosok)
            {
                if (jatekos.elso.Contains("1980"))
                {
                    elso1980.Add(jatekos);
                    Console.WriteLine($"\t {jatekos.nev}");
                }
            }
            /*
            //3. feladat
            Console.WriteLine("3. feladat: Kérek egy nevet:");
            string bekertNev =Console.ReadLine();
            bool van_e;
            int j = 0;
            while (j < elso1980 && van_e == false)
            {

            }
            
            //4. feladat
            Console.Write("3. feladat: Kérek egy 1990 és 1999 közti évszámot:");
            int bekertEvaszam = Convert.ToInt32(Console.ReadLine());
            bool feltetel = false;
            int i = 0;
            while (!feltetel)
            {


                if (bekertEvaszam >= 1990 && bekertEvaszam <= 1999)
                {

                    foreach (Jatekos jatekos in jatekosok)
                    {
                        if (jatekos.elso == bekertEvaszam)
                        {
                            Console.WriteLine($"{jatekos.nev}, {jatekos.elso}, {jatekos.utolso}, {jatekos.suly}, {jatekos.magassag}");
                        }
                    }

                }
                else
                {
                    Console.Write("Hibás adat, kérek egy 1990 és 1999 közötti évszámot!:");
                    int ujBekertEvszam = Convert.ToInt32(Console.ReadLine());
                    ujBekertEvszam = bekertEvaszam;
                    i++;
                } 
                */

            //5. feladat

            Console.ReadLine();





        
                
        }   
    }
}
