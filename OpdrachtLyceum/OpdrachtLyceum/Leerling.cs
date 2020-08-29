using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLyceum
{
    class Leerling
    {
        public string Naam { get; private set; }
        static int leerlingCount = 0;
        public Leerling()
        {
            leerlingCount++;
            Naam = "Leerling" + leerlingCount;
        }
    }
}
