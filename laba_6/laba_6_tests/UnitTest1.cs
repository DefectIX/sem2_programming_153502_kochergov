using System;
using laba_6;
using Xunit;

namespace laba_6_tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(5)]
		[InlineData(0)]
		[InlineData(1e6)]
		public void CavalryTest(int value)
		{
			const double baseAttack = 5;
			const double baseSpeed = 10;

			Cavalry cavalry = new Cavalry();
			Assert.Equal(baseAttack, cavalry.AttackStrength());
			Assert.Equal(baseSpeed, cavalry.MovementSpeed());

			cavalry.IncreaseAttackStrength(value);
			Assert.Equal(baseAttack + value, cavalry.AttackStrength());

			cavalry.IncreaseMovementSpeed(value);
			Assert.Equal(baseSpeed + value, cavalry.MovementSpeed());
			cavalry.IncreaseMovementSpeed(0.5);
			Assert.Equal(baseSpeed + 0.5 + value, cavalry.MovementSpeed());

			Assert.Equal("[Cavalry] Speed: " + cavalry.MovementSpeed() + ", Strength: " + cavalry.AttackStrength(),
				cavalry.ToStringOutput());

			Assert.False(cavalry.IsHeavyCavalry());
		}

		[Theory]
		[InlineData(5)]
		[InlineData(0)]
		[InlineData(1e6)]
		public void InfantryTest(int value)
		{
			const double baseAttack = 5;
			const double baseSpeed = 4;

			Infantry infantry = new Infantry();
			Assert.Equal(baseAttack, infantry.AttackStrength());
			Assert.Equal(baseSpeed, infantry.MovementSpeed());

			infantry.IncreaseAttackStrength(value);
			Assert.Equal(baseAttack + value, infantry.AttackStrength());

			infantry.IncreaseMovementSpeed(value);
			Assert.Equal(baseSpeed + value, infantry.MovementSpeed());

			Assert.Equal("[Army unit] Speed: " + infantry.MovementSpeed() + ", Strength: " + infantry.AttackStrength(),
				infantry.ToStringOutput());
		}

		[Theory]
		[InlineData(5)]
		[InlineData(0)]
		[InlineData(1e6)]
		public void HeavyCavalryTest(int value)
		{
			const double baseAttack = 8;
			const double baseSpeed = 6;

			HeavyCavalry heavyCavalry = new HeavyCavalry();
			Assert.Equal(baseAttack, heavyCavalry.AttackStrength());
			Assert.Equal(baseSpeed, heavyCavalry.MovementSpeed());

			heavyCavalry.IncreaseAttackStrength(value);
			Assert.Equal(baseAttack + value, heavyCavalry.AttackStrength());

			heavyCavalry.IncreaseMovementSpeed(value);
			Assert.Equal(baseSpeed + value, heavyCavalry.MovementSpeed());

			Assert.True(heavyCavalry.IsHeavyCavalry());
		}
	}
}
