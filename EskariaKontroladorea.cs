using System;
using System.Collections.Generic;

namespace Proiektua
{
    public static class EskariaKontroladorea
    {
        public static void SortuEskaeraBerria(List<Eskaera> listaEskaerak)
        {
            Console.Clear();
            Console.WriteLine("=== ESKARI BERRIA SORTU ===");

            string izena = Besteak.EskareraTestua("Sartu bezeroaren izena: ");
            string tamaina = Besteak.EskareraTamaina();
            string haragiaMota = Besteak.EskareraHaragiaMota();
            List<string> osagaiak = Besteak.EskareraOsagaiak();
            string edaria = Besteak.EskareraTestua("Sartu edaria: ");
            string osagarria = Besteak.EskareraTestua("Sartu osagarria: ");

            Eskaera eskaeraBerria = new Eskaera(izena, tamaina, haragiaMota, osagaiak, edaria, osagarria);
            listaEskaerak.Add(eskaeraBerria);

            Besteak.ErakutsiEskaeraLaburpena(eskaeraBerria);
            Besteak.Pausa();
        }

        public static void IkusiAurrekoEskaerak(List<Eskaera> listaEskaerak)
        {
            Console.Clear();
            Console.WriteLine("=== IKUSI AURREKO ESKAERAK ===");

            if (listaEskaerak.Count == 0)
                Console.WriteLine("Ez dago aurreko eskaerarik.");
            else
            {
                for (int i = 0; i < listaEskaerak.Count; i++)
                {
                    Console.WriteLine($"\n--- ESKAERA {i + 1} ---");
                    Besteak.ErakutsiEskaeraLaburpena(listaEskaerak[i]);
                }
            }
            Besteak.Pausa();
        }

        public static void BilatuEskaeraIzenarenArabera(List<Eskaera> listaEskaerak)
        {
            Console.Clear();
            Console.WriteLine("=== BILATU ESKAERA IZENAREN ARABERA ===");

            string izena = Besteak.EskareraTestua("Sartu bezeroaren izena bilatzeko: ");
            int kontagailua = 0;

            for (int i = 0; i < listaEskaerak.Count; i++)
            {
                if (listaEskaerak[i].BezeroarenIzena.ToLower() == izena.ToLower())
                {
                    Console.WriteLine($"\n--- ESKAERA #{kontagailua + 1} ---");
                    Besteak.ErakutsiEskaeraLaburpena(listaEskaerak[i]);
                    kontagailua++;
                }
            }

            if (kontagailua == 0)
                Console.WriteLine("Ez da aurkitu eskaerarik emandako izenarekin.");

            Besteak.Pausa();
        }

public static void EzabatuEskaera(List<Eskaera> listaEskaerak)
{
    Console.Clear();
    Console.WriteLine("=== EZABATU ESKAERA ===");

    string izena = Besteak.EskareraTestua("Sartu ezabatu nahi duzun bezeroaren izena: ");

    bool batDago = false;
    for (int i = 0; i < listaEskaerak.Count; i++)
    {
        if (listaEskaerak[i].BezeroarenIzena.ToLower() == izena.ToLower())
        {
            Console.WriteLine("\n--- ESKAERA #" + (i + 1) + " ---");
            Besteak.ErakutsiEskaeraLaburpena(listaEskaerak[i]);
            batDago = true;
        }
    }

    if (!batDago)
    {
        Console.WriteLine("Ez da aurkitu eskaerarik emandako izenarekin.");
        Besteak.Pausa();
        return;
    }

    Console.Write("Sartu ezabatu nahi duzun eskaeraren zenbakia: ");
    string sAukera = Console.ReadLine();
    int aukera = int.Parse(sAukera) - 1;

    if (aukera >= 0 && aukera < listaEskaerak.Count)
    {
        listaEskaerak.RemoveAt(aukera);
        Console.WriteLine("Eskaera arrakastaz ezabatu da.");
    }
    else
    {
        Console.WriteLine("Zenbaki baliogabea.");
    }

    Besteak.Pausa();
}
    }
}