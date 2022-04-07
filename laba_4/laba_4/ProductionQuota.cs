using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
	public class ProductionQuota
	{
		public ProductionQuota()
		{
		}

		public ProductionQuota(long hoursPerMonth)
		{
			HoursPerMonth = hoursPerMonth;
		}


		public long HoursPerMonth { get; private set; } = 160;

		public void IncreaseHoursBy(long value)
		{
			HoursPerMonth += value;
		}

		public void DecreaseHoursBy(long value)
		{
			HoursPerMonth -= value;
		}

		public override string ToString()
		{
			return HoursPerMonth.ToString();
		}

		public static ProductionQuota Parse(string ProductionQuota)
		{
			return new ProductionQuota(long.Parse(ProductionQuota));
		}
	}
}
