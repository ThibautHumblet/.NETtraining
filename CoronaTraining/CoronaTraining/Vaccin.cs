using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTraining
{
    class Vaccin
    {
        private string _name { get; set; }
        public int Oplossing { get; set; } = -1;

        public Vaccin(string name)
        {
            _name = name;
        }

        public Vaccin(string name, int oplossing)
        {
            _name = name;
            Oplossing = oplossing;
        }

        public int TryKillCode()
        {
            Random random = new Random();
            if (Oplossing == -1)
                return random.Next(0, 100);
            else
                return Oplossing;
        }

        public void ToonInfo()
        {
            Console.WriteLine(_name);
            Console.WriteLine(Oplossing);
        }
    }
}
