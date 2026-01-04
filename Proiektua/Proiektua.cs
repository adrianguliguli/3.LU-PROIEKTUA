// ===============================================
//  Empresaren izena: Burger Express
//  Egilea: Ádrian Corroza
// ===============================================
using System;
using System.Collections.Generic;

namespace Proiektua
{
    public class sProiektua
    {
        
        private List<Eskaera> listaEskaerak = new List<Eskaera>();

        
        private string menuEguneko = "Burguer Express Special";

        public void Run()
        {
            Besteak.LehenMezua();
            MenuNagusia();
        }

        private void MenuNagusia()
        {
            int aukera = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU NAGUSIA =====");
                Console.WriteLine("1. Sortu eskaera berria");
                Console.WriteLine("2. Ikusi aurreko eskaerak");
                Console.WriteLine("3. Bilatu eskaera izenaren arabera");
                Console.WriteLine("4. Ezabatu eskaera");
                Console.WriteLine("5. Erakutsi estatistikak");
                Console.WriteLine("6. Eguneko menuaren konfigurazioa");
                Console.WriteLine("7. Irten");
                Console.WriteLine("==========================");
                Console.Write("Aukeratu aukera bat (1-7): ");

                string sAukera = Console.ReadLine();
                if (sAukera == "1") EskariaKontroladorea.SortuEskaeraBerria(listaEskaerak);
                else if (sAukera == "2") EskariaKontroladorea.IkusiAurrekoEskaerak(listaEskaerak);
                else if (sAukera == "3") EskariaKontroladorea.BilatuEskaeraIzenarenArabera(listaEskaerak);
                else if (sAukera == "4") EskariaKontroladorea.EzabatuEskaera(listaEskaerak);
                else if (sAukera == "5") Estatistikak.ErakutsiEstatistikak(listaEskaerak);
                else if (sAukera == "6") menuEguneko = MenuKontroladorea.EgunekoMenuarenKonfigurazioa(menuEguneko);
                else if (sAukera == "7") 
                {
                    Besteak.Irten();
                    return;
                }
                else
                {
                    Console.WriteLine("Aukera ez da baliozkoa. Saiatu berriro.");
                    Besteak.Pausa();
                }

            } while (aukera != 7);
        }
    }
}