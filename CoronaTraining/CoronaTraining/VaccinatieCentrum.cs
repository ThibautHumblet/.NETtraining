using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTraining
{
    class VaccinatieCentrum
    {
        public static int Oplossing { get; set; } = -1;
        public void BewaarVaccin(int killcode)
        {
            Oplossing = killcode;
        }

        public Vaccin GeefVaccin()
        {
            if (Oplossing == -1)
                return null;
            else
                return new Vaccin("CoronaVaccin", Oplossing);
        }

    }
}
