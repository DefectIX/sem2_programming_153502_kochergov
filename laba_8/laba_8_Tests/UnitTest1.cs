using System;
using Xunit;
using laba_8;

namespace laba_8_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(10, 10, 10, 10)]
		[InlineData(7, 11, 13, 17)]
		[InlineData(1e6, 1e6, 1e6, 1e6)]
		public void PayrollDepartmentTest(double val1, double val2, double val3, double val4)
		{
			PayrollDepartment department = new PayrollDepartment();
			for (int i = 0; i < val1; i++)
				department.AddJobWithNoBonus(i.ToString(), val2);
			for (int i = 0; i < val1; i++)
				department.AddJobWithPercentBonus(i.ToString(), val3, val4);

			Assert.Equal((1.0 * val2 + (val3 * (1 + val4 * 0.01))) / 2, department.GetAveragePayment(), 8);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(10, 10)]
		[InlineData(23, 19)]
		[InlineData(1e6, 1e6)]
		public void PercentBonusTest(double val1, double val2)
		{
			PercentBonus payment = new PercentBonus(val1, val2);
			Assert.Equal(val1 * (1 + val2 * 0.01), payment.GetPayment(), 8);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(10)]
		[InlineData(19)]
		[InlineData(1e6)]
		public void NoBonusTest(double val1)
		{
			NoBonus payment = new NoBonus(val1);
			Assert.Equal(val1, payment.GetPayment(), 8);
		}

	}
}
