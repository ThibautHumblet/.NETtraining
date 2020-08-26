using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Corona Oefening");
            Console.WriteLine("Deze oefening kwam van https://apwt.gitbook.io/ziescherp/semester-2-oop/module-3-eindetest/opgave3_corona");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Virus virus;
            Vaccin testvaccin;
            Vaccin coronaVaccin = null;
            VaccinatieCentrum vaccinatieCentrum;

            virus = new Virus();

            List<Vaccin> vaccins = new List<Vaccin>();
            for (int i = 0; i < 5; i++)
            {
                testvaccin = new Vaccin(i.ToString());
                vaccins.Add(testvaccin);
            }

            bool vaccinGevonden = false;
            while (vaccinGevonden == false && virus.DoomCountdown > 0)
            {
                foreach (Vaccin vac in vaccins)
                {
                    if (virus.TryVaccin(vac) == true)
                    {
                        coronaVaccin = vac;
                        vaccinGevonden = true;
                        Console.WriteLine("Gevonden!");
                        break;
                    }
                    Console.WriteLine("Niet gevonden!");
                }

            }

            if (vaccinGevonden)
            {
                coronaVaccin.ToonInfo();
                vaccinatieCentrum = new VaccinatieCentrum();
                vaccinatieCentrum.BewaarVaccin(coronaVaccin.Oplossing);
                List<VaccinatieCentrum> vaccinatieCentra = new List<VaccinatieCentrum>();
                for (int i = 0; i < 5; i++)
                {
                    vaccinatieCentra.Add(new VaccinatieCentrum());
                }

                List<Vaccin> coronaVaccins = new List<Vaccin>();
                foreach (var centrum in vaccinatieCentra)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        coronaVaccins.Add(centrum.GeefVaccin());
                    }
                }

                for (int i = 0; i < coronaVaccins.Count; i++)
                {
                    Console.WriteLine(i);
                    coronaVaccins[i].ToonInfo();
                }
            }

            Console.ReadLine();
        }
    }
}
