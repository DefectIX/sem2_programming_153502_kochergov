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
		public void PayrollDepartmentTest(long val1, long val2, long val3, long val4)
		{
			PayrollDepartment department = new PayrollDepartment();
			for (int i = 0; i < val1; i++)
				department.AddJobWithNoBonus(i.ToString(), val2);
			for (int i = 0; i < val1; i++)
				department.AddJobWithAbsBonus(i.ToString(), val3, val4);

			Assert.Equal((1.0 * val2 + val3 + val4) / 2, department.GetAveragePayment());
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(10, 10)]
		[InlineData(23, 19)]
		[InlineData(1e6, 1e6)]
		public void AbsBonusTest(long val1, long val2)
		{
			AbsBonus payment = new AbsBonus(val1, val2);
			Assert.Equal(val1 + val2, payment.GetPayment());
		}

		[Theory]
		[InlineData(0)]
		[InlineData(10)]
		[InlineData(19)]
		[InlineData(1e6)]
		public void NoBonusTest(long val1)
		{
			NoBonus payment = new NoBonus(val1);
			Assert.Equal(val1, payment.GetPayment());
		}

	}
}
