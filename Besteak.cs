using System;
using System.Collections.Generic;

namespace Proiektua
{
    public static class Besteak
    {
        public static void LehenMezua()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("       Ongi etorri Burger Express        ");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine("Sakatu ENTER jarraitzeko...");
            Console.ReadLine();
        }

        public static void Pausa()
        {
            Console.WriteLine();
            Console.WriteLine("Sakatu ENTER jarraitzeko...");
            Console.ReadLine();
        }

        public static string EskareraTamaina()
        {
            Console.WriteLine("Aukeratu hamburguesaren tamaina:");
            Console.WriteLine("1. Txikia (S)");
            Console.WriteLine("2. Ertaina (M)");
            Console.WriteLine("3. Handia (L)");

            string sAukera = Console.ReadLine();
            if (sAukera == "1") return "Txikia";
            if (sAukera == "2") return "Ertaina";
            if (sAukera == "3") return "Handia";
            return "Ertaina"; // Defektuz
        }

        public static string EskareraHaragiaMota()
        {
            Console.WriteLine("Aukeratu haragi mota:");
            Console.WriteLine("1. Behi haragia");
            Console.WriteLine("2. Oiloa");
            Console.WriteLine("3. Barazkiak");

            string sAukera = Console.ReadLine();
            if (sAukera == "1") return "Behi haragia";
            if (sAukera == "2") return "Oiloa";
            if (sAukera == "3") return "Barazkiak";
            return "Behi haragia"; // Defektuz
        }
        public static List<string> EskareraOsagaiak()
        {
            List<string> osagaiak = new List<string>();
            string[] aukerak = { "Gazta", "Bacon", "Letxuga", "Tomate", "Tipula" };

            Console.WriteLine("Aukeratu osagai osagarriak:");
            for (int i = 0; i < aukerak.Length; i++)
            {
                Console.Write($"Osagai {aukerak[i]} nahi duzu? (b/e): ");
                string erantzuna = Console.ReadLine();
                if (erantzuna.ToLower() == "b")
                    osagaiak.Add(aukerak[i]);
            }

            return osagaiak;
        }
        public static void ErakutsiEskaeraLaburpena(Eskaera p)
        {
            Console.WriteLine("\n=== ESKAERAREN LABURPENA ===");
            Console.WriteLine($"Bezeroa: {p.BezeroarenIzena}");
            Console.WriteLine($"Tamaina: {p.Tamaina}");
            Console.WriteLine($"Haragi mota: {p.HaragiaMota}");
            Console.Write("Osagai osagarriak: ");
            if (p.Osagaiak.Count > 0)
            {
                Console.WriteLine(string.Join(", ", p.Osagaiak));
            }
            else
            {
                Console.WriteLine("Ezer ez");
            }
            Console.WriteLine($"Edaria: {p.Edaria}");
            Console.WriteLine($"Osagarria: {p.Osagarria}");
            Console.WriteLine("==========================");
        }
        public static void Irten()
        {
            Console.Clear();
            Console.WriteLine("Eskerrik asko Burger Express aukeratzeagatik!");
            Console.WriteLine("Gero arte!");
            Pausa();
        }
        public static string EskareraTestua(string mezua)
        {
            Console.Write(mezua);
            string s = Console.ReadLine();
            if (s == null) return "";
            return s;
        }

    }
}
