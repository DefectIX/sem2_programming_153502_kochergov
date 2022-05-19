using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	class PayrollDepartment
	{
		private List<Job> lstJobs;

		public PayrollDepartment()
		{
			lstJobs = new List<Job>();
		}

		public void AddJobWithNoBonus(string name, long payment)
		{
			lstJobs.Add(new Job(name, new NoBonus(payment)));
		}

		public void AddJobWithAbsBonus(string name, long payment, long absBonus)
		{
			lstJobs.Add(new Job(name, new AbsBonus(payment, absBonus)));
		}

		public double GetAveragePayment()
		{
			double sum = 0;
			foreach (var job in lstJobs)
			{
				sum += job.GetPayment();
			}
			return sum / lstJobs.Count;
		}
	}
}
