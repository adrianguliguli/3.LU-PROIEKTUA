using System;
using System.Collections.Generic;

namespace Proiektua
{
    public class Eskaera
    {
        public string BezeroarenIzena { get; set; }
        public string Tamaina { get; set; }
        public string HaragiaMota { get; set; }
        public List<string> Osagaiak { get; set; }
        public string Edaria { get; set; }
        public string Osagarria { get; set; }

        public Eskaera()
        {
            Osagaiak = new List<string>();
        }
        public Eskaera(string izena, string tamaina, string haragia, List<string> osagaiak, string edaria, string osagarria)
        {
            BezeroarenIzena = izena;
            Tamaina = tamaina;
            HaragiaMota = haragia;
            Osagaiak = osagaiak;
            Edaria = edaria;
            Osagarria = osagarria;
        }
    }
}
