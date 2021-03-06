﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTraining
{
    class Virus
    {
        public string NaamVirus { get; private set; }
		private int doomCountdown;
		string randomName;

		public int DoomCountdown
		{
			get { return doomCountdown; }
			set 
			{ 
				if (doomCountdown <= 0)
					Console.WriteLine("Game Over " + NaamVirus);
				doomCountdown = value;
			}
		}

		private int killcode;

		public Virus()
		{
			Random random = new Random();
			doomCountdown = random.Next(10, 21);
			killcode = random.Next(0, 100);
			for (int i = 0; i < 3; i++)
			{
				string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				int num = random.Next(0, chars.Length - 1);
				randomName += chars[num];
			}
			randomName += random.Next(1, 100);
		}

		public bool TryVaccin(Vaccin vaccin)
		{
			if (vaccin.TryKillCode() == killcode)
			{
				vaccin.Oplossing = killcode;
				return true;
			}
			else
			{
				DoomCountdown--;
				return false;
			}
		}

	}
}
