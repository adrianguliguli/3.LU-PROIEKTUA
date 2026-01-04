using System;
using System.Collections.Generic;

namespace Proiektua
{
    public static class Estatistikak
    {
        public static void ErakutsiEstatistikak(List<Eskaera> listaEskaerak)
        {
            Console.Clear();
            Console.WriteLine("=== ESTATISTIKAK ===");

            int totalEskaerak = listaEskaerak.Count;
            Console.WriteLine("Guztira eskaerak: " + totalEskaerak);

            if (totalEskaerak == 0)
            {
                Console.WriteLine("Ez dago estatistikarik oraindik");
                Besteak.Pausa();
                return;
            }

            int txikia = 0;
            int ertaina = 0;
            int handia = 0;
            int behi = 0;
            int oiloa = 0;
            int barazkiak = 0;
            Dictionary<string, int> osagaiKopurua = new Dictionary<string, int>();

            for (int i = 0; i < listaEskaerak.Count; i++)
            {
                Eskaera eskaera = listaEskaerak[i];

                // Tamaina
                if (eskaera.Tamaina == "Txikia") txikia++;
                else if (eskaera.Tamaina == "Ertaina") ertaina++;
                else if (eskaera.Tamaina == "Handia") handia++;

                // Haragia mota
                if (eskaera.HaragiaMota == "Behi haragia") behi++;
                else if (eskaera.HaragiaMota == "Oiloa") oiloa++;
                else if (eskaera.HaragiaMota == "Barazkiak") barazkiak++;

                // Osagai osagarriak
                for (int j = 0; j < eskaera.Osagaiak.Count; j++)
                {
                    string osagaia = eskaera.Osagaiak[j];
                    if (osagaiKopurua.ContainsKey(osagaia))
                        osagaiKopurua[osagaia]++;
                    else
                        osagaiKopurua[osagaia] = 1;
                }
            }

            // Estatistikak erakustea
            Console.WriteLine("\n=== Tamainen arabera ===");
            Console.WriteLine("Txikia: " + txikia);
            Console.WriteLine("Ertaina: " + ertaina);
            Console.WriteLine("Handia: " + handia);

            Console.WriteLine("\n=== Haragi motaren arabera ===");
            Console.WriteLine("Behi haragia: " + behi);
            Console.WriteLine("Oiloa: " + oiloa);
            Console.WriteLine("Barazkiak: " + barazkiak);

            Console.WriteLine("\n=== Osagai osagarrien arabera ===");
            foreach (KeyValuePair<string, int> osagaia in osagaiKopurua)
            {
                Console.WriteLine(osagaia.Key + ": " + osagaia.Value);
            }

            Besteak.Pausa();
        }
    }
}
