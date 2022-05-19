using System;

namespace laba_8
{
	class Program
	{
		static void Main(string[] args)
		{
			PayrollDepartment department = new PayrollDepartment();
			department.AddJobWithNoBonus("Job 1", 100);
			department.AddJobWithNoBonus("Job 2", 50);
			department.AddJobWithPercentBonus("Job 3", 100, 50);
			Console.WriteLine("Average payment: " + department.GetAveragePayment());
			Console.WriteLine("Average payment without bonus: " + department.GetAveragePaymentWithoutBonus());
		}
	}
}
