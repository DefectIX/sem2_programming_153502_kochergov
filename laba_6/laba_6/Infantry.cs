using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	public class Infantry : ArmyUnit
	{
		public Infantry()
		{
			_movementSpeed = 4;
			_attackStrength = 5;
		}

		public override void IncreaseMovementSpeed(int dSpeed)
		{
			_movementSpeed += dSpeed;
		}

		public override void IncreaseAttackStrength(int dAttack)
		{
			_attackStrength += dAttack;
		}
	}
}
