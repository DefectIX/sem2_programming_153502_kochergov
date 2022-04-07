using System;
using System.IO;

namespace laba_4
{
	class Program
	{
		static void Main(string[] args)
		{
			var department = HRDepartment.Instance;
			department.CompanyName = "SpaceX";
			department.IncomeTax = 0.2;
			department.PaymentPerHour = 1000;
			department.QuotaHoursPerMonth = new ProductionQuota(20);
			department.WorkersNumber = 50;
			Console.WriteLine($"Company name: {department.CompanyName}\n" +
			                  $"Workers number: {department.WorkersNumber}\n" +
			                  $"Payment per hour: {department.PaymentPerHour}\n" +
			                  $"Income tax: {department.IncomeTax}\n" +
			                  $"Quota hours per month: {department.QuotaHoursPerMonth}\n"+
			                  $"Tax payment per month: {department.TaxPaymentPerMonth()}");
			using (StreamWriter writer = new StreamWriter(@"C:\Department\department_output.txt"))
			{
				writer.Write(department.ToString());
			}


			using (StreamReader reader = new StreamReader(@"C:\Department\department_input.txt"))
			{
				HRDepartment.Parse(reader.ReadToEnd());
			}

			Console.Write("\n\n\n");
			Console.WriteLine($"Company name: {department.CompanyName}\n" +
			                  $"Workers number: {department.WorkersNumber}\n" +
			                  $"Payment per hour: {department.PaymentPerHour}\n" +
			                  $"Income tax: {department.IncomeTax}\n" +
			                  $"Quota hours per month: {department.QuotaHoursPerMonth}\n" +
			                  $"Tax payment per month: {department.TaxPaymentPerMonth()}");

		}
	}
}
