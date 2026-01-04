using System;

namespace Proiektua
{
    public static class MenuKontroladorea
    {
        public static string EgunekoMenuarenKonfigurazioa(string menuActual)
        {
            Console.Clear();
            Console.WriteLine("=== EGUNEKO MENUAREN KONFIGURAZIOA ===");
            Console.WriteLine($"Eguneko menu aktuala: {menuActual}");
            Console.Write("Sartu egunerako menu berria: ");
            string menuBerria = Console.ReadLine();
            Console.WriteLine($"Eguneko menu berria ezarri da: {menuBerria}");
            Besteak.Pausa();
            return menuBerria;
        }
    }
}