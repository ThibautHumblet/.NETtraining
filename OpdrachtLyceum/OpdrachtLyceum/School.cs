using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLyceum
{
    class School
    {
        private int geldHoeveelheid;
        public int GeldHoeveelheid {
            get
            {
                return geldHoeveelheid;
            }
            private set
            {
                if (value > 15)
                    geldHoeveelheid = value;
                else
                    geldHoeveelheid = 15;
            }
        }
        public bool IsBijnaLeeg { 
            get
            {
                if (geldHoeveelheid <= 15)
                    return true;
                else
                    return false;
            }
        }
        public List<Leerling> Leerlingen { get; set; } = new List<Leerling>(15);
        public string Naam { get; set; } = "school90";

        public void GeefGeld(double geld)
        {
            geldHoeveelheid += (int)geld;
        }

        public bool MaakLeerling()
        {
            if (geldHoeveelheid >= 40 && Leerlingen.Count<=15)
            {
                geldHoeveelheid -= 15;
                Leerlingen.Add(new Leerling());
                return true;
            }
            return false;
        }

        public Leerling GeefLeerling()
        {
            if (Leerlingen.Count >= 2)
            {
                Leerling leerlingPlaceholder = Leerlingen[0];
                Leerlingen.Remove(Leerlingen[0]);
                return leerlingPlaceholder;
            }
            else
                return null;
        }

        public override string ToString()
        {
            return $"{GeldHoeveelheid},{IsBijnaLeeg},{Leerlingen.Count}"; 
        }
    }
}
