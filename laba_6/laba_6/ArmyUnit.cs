//
// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	public abstract class ArmyUnit
	{
		protected double _movementSpeed = 1;
		protected double _attackStrength = 1;

		public double MovementSpeed()
		{
			return _movementSpeed;
		}

		public double AttackStrength()
		{
			return _attackStrength;
		}

		public abstract void IncreaseMovementSpeed(int dSpeed);

		public abstract void IncreaseAttackStrength(int dAttack);

		public virtual string ToStringOutput()
		{
			return "[Army unit] Speed: " + _movementSpeed + ", Strength: " + _attackStrength;
		}
	}
}
