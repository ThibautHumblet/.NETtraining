using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLyceum
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht Lyceum");
            Console.WriteLine("Deze opdracht kwam van https://apwt.gitbook.io/ziescherp/semester-2-oop/module-4-eindetest/opgave_1920");
            Console.WriteLine("---------------");

            School s = new School();
            var WerkStudenten = new List<Leerling>();

            for (int i = 0; i < 15; i++)
            {
                s.GeefGeld(r.Next(15, 30));
                if (s.MaakLeerling())
                {
                    if (r.Next(0, 100) >= 60)
                    {
                        Leerling toadd = s.GeefLeerling();
                        if (toadd != null)
                            WerkStudenten.Add(toadd);
                    }
                }
                Console.WriteLine(s);
            }

            foreach (var werkstudent in WerkStudenten)
            {
                Console.WriteLine(werkstudent.Naam);
            }

            Console.ReadLine();
        }
    }
}
