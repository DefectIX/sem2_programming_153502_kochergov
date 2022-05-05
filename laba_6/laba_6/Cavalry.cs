using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	public class Cavalry : ArmyUnit
	{
		public Cavalry()
		{
			Console.WriteLine("Base class constructor [Cavalry class]");
			_movementSpeed = 10;
			_attackStrength = 5;
		}

		public override void IncreaseMovementSpeed(int dSpeed)
		{
			_movementSpeed += dSpeed;
		}

		public void IncreaseMovementSpeed(double dSpeed)
		{
			_movementSpeed += dSpeed;
		}

		public override void IncreaseAttackStrength(int dAttack)
		{
			_attackStrength += dAttack;
		}

		public override string ToStringOutput()
		{
			return "[Cavalry] Speed: " + _movementSpeed + ", Strength: " + _attackStrength;
		}

		public bool IsHeavyCavalry()
		{
			return false;
		}
	}
}
