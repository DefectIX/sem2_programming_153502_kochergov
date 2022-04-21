using System;
using Xunit;
using laba_5;

namespace laba_5_tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(0)]
		[InlineData(123)]
		[InlineData(10000)]
		public void GetSalaryBySurname_Test(long salary)
		{
			PayrollDepartment department = new PayrollDepartment();
			department.AddEmployee("Surname1");
			department.AddWork("Work1", salary, Work.WorkType.OutsideOffice);
			department.AddWorkForEmployee("Surname1", "Work1");
			Assert.Equal(salary, department.GetSalaryBySurname("Surname1"));
		}

		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(11, 12, 23)]
		[InlineData(10000, 10000, 20000)]
		public void GetTotalPayment_Test(long firstSalary, long secondSalary, long expected)
		{
			PayrollDepartment department = new PayrollDepartment();
			department.AddEmployee("Surname1");
			department.AddEmployee("Surname2");
			department.AddWork("Work1", firstSalary, Work.WorkType.OutsideOffice);
			department.AddWork("Work2", secondSalary, Work.WorkType.OutsideOffice);
			department.AddWorkForEmployee("Surname1", "Work1");
			department.AddWorkForEmployee("Surname2", "Work2");
			Assert.Equal(expected, department.GetTotalPayment());
		}
	}
}
