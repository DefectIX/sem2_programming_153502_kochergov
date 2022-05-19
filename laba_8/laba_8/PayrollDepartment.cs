using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	public class PayrollDepartment
	{
		private List<Job> lstJobs;

		public PayrollDepartment()
		{
			lstJobs = new List<Job>();
		}

		public void AddJobWithNoBonus(string name, double payment)
		{
			lstJobs.Add(new Job(name, new NoBonus(payment)));
		}

		public void AddJobWithPercentBonus(string name, double payment, double percentBonus)
		{
			lstJobs.Add(new Job(name, new PercentBonus(payment, percentBonus)));
		}

		public double GetAveragePayment()
		{
			if (lstJobs.Count == 0)
				return 0;
			double sum = 0;
			foreach (var job in lstJobs)
			{
				sum += job.GetPayment();
			}
			return sum / lstJobs.Count;
		}
	}
}
