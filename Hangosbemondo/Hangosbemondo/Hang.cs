using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangosbemondo
{
    class Hang
    {
        public string Fajlnev { get; set; }
        public string Eleresiut { get; set; }
        public string Megjelenitesi_nev { get; set; }
        public string Szinkronhang_neve { get; set; }

        public Hang(string sor)
        {
            string[] darab = sor.Split(';');
            Fajlnev = darab[0];
            Eleresiut = darab[1];
            Megjelenitesi_nev = darab[2];
            Szinkronhang_neve = darab[3];
        }
    }
}
