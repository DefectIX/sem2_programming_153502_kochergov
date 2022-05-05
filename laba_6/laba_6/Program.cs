using System;
using System.Collections.Generic;

namespace laba_6
{
	class Program
	{
		public static List<ArmyUnit> lstArmyUnits = new List<ArmyUnit>();
		static void Main(string[] args)
		{
			ArmyUnit cavalry = new Cavalry();
			ArmyUnit heavyCavalry = new HeavyCavalry();
			ArmyUnit infantry = new Infantry();
			lstArmyUnits.Add(cavalry);
			lstArmyUnits.Add(heavyCavalry);
			lstArmyUnits.Add(infantry);

			Console.Write("\n\n");
			PrintObjects();
			Console.Write("\n\n");

			cavalry.IncreaseAttackStrength(100);
			cavalry.IncreaseMovementSpeed(100);
			((Cavalry)cavalry).IncreaseMovementSpeed(100.1);
			Console.WriteLine(cavalry.AttackStrength());
			Console.WriteLine(cavalry.MovementSpeed());
			Console.WriteLine(((Cavalry)cavalry).IsHeavyCavalry());
			Console.Write("\n\n");

			Console.WriteLine(((HeavyCavalry)heavyCavalry).IsHeavyCavalry());
			Console.Write("\n\n");

			infantry.IncreaseAttackStrength(50);
			infantry.IncreaseMovementSpeed(50);
			Console.WriteLine(infantry.ToStringOutput());
			Console.Write("\n\n");
		}

		public static void PrintObjects()
		{
			foreach (var armyUnit in lstArmyUnits)
			{
				Console.WriteLine(armyUnit.ToStringOutput());
			}
		}
	}
}
