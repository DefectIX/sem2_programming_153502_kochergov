using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	sealed class HeavyCavalry : Cavalry
	{
		public HeavyCavalry()
		{
			Console.WriteLine("Derived class constructor [HeavyCavalry class]");
			_movementSpeed = 6;
			_attackStrength = 8;
		}

		public bool IsHeavyCavalry()
		{
			return true;
		}
	}
}
