using System;
using System.Runtime.InteropServices;
using Xunit;
using laba_4;

namespace laba_4_tests
{
	public class UnitTest1
	{
		[Fact]
		public void HRDepartment_SingletonTest()
		{
			Assert.NotNull(HRDepartment.Instance);
			var department1 = HRDepartment.Instance;
			var department2 = HRDepartment.Instance;

			Assert.Equal(department1, department2);
		}

		[Theory]
		[InlineData(1, 1, 1, 1, 1)]
		[InlineData(2, 5, 0.2, 5, 10)]
		[InlineData(100, 1000, 0.01, 100, 100000)]
		public void HRDepartment_TaxPaymentPerMonthTest(long workersNumber, long paymentPerHour,
			double incomeTax, long quotaHoursPerMonth, long expected)
		{
			var department = HRDepartment.Instance;
			department.WorkersNumber = workersNumber;
			department.PaymentPerHour = paymentPerHour;
			department.IncomeTax = incomeTax;
			department.QuotaHoursPerMonth = new ProductionQuota(quotaHoursPerMonth);

			Assert.Equal(expected, department.TaxPaymentPerMonth());
		}

		[Fact]
		public void HRDepartment_ToStringTest()
		{
			var department = HRDepartment.Instance;
			department.CompanyName = "1";
			department.WorkersNumber = 2;
			department.PaymentPerHour = 3;
			department.IncomeTax = 0.4;
			department.QuotaHoursPerMonth = new ProductionQuota(5);

			Assert.Equal("1\n2\n3\n0,4\n5", department.ToString());
		}

		[Fact]
		public void HRDepartment_ParseTest()
		{
			var department = HRDepartment.Instance;
			HRDepartment.Parse("1\n2\n3\n0,4\n5");
			Assert.Equal("1", department.CompanyName);
			Assert.Equal(2, department.WorkersNumber);
			Assert.Equal(3, department.PaymentPerHour);
			Assert.Equal(0.4, department.IncomeTax);
			Assert.Equal(new ProductionQuota(5).HoursPerMonth, department.QuotaHoursPerMonth.HoursPerMonth);
		}

		[Theory]
		[InlineData(10, 10, 20)]
		[InlineData(0, 50, 50)]
		public void ProductionQuota_IncreaseHoursByTest(long value, long increaseBy, int expected)
		{
			ProductionQuota quota = new ProductionQuota(value);
			quota.IncreaseHoursBy(increaseBy);

			Assert.Equal(expected, quota.HoursPerMonth);
		}

		[Theory]
		[InlineData(20, 10, 10)]
		[InlineData(50, 50, 0)]
		public void ProductionQuota_DecreaseHoursByTest(long value, long decreaseBy, int expected)
		{
			ProductionQuota quota = new ProductionQuota(value);
			quota.DecreaseHoursBy(decreaseBy);

			Assert.Equal(expected, quota.HoursPerMonth);
		}

	}
}
