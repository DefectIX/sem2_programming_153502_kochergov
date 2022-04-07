using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
	public class HRDepartment
	{
		private HRDepartment() { }

		private static HRDepartment _instance;

		public static HRDepartment Instance
		{
			get
			{
				if (_instance == null)
					_instance = new HRDepartment();
				return _instance;
			}
		}

		public static void Parse(string HRDepartment)
		{
			var lines = HRDepartment.Split('\n');
			Instance.CompanyName = lines[0];
			Instance.WorkersNumber = long.Parse(lines[1]);
			Instance.PaymentPerHour = long.Parse(lines[2]);
			Instance.IncomeTax = double.Parse(lines[3]);
			Instance.QuotaHoursPerMonth = ProductionQuota.Parse(lines[4]);
		}

		public string CompanyName { get; set; }
		public long WorkersNumber { get; set; }
		public long PaymentPerHour { get; set; }
		public double IncomeTax { get; set; }
		public ProductionQuota QuotaHoursPerMonth { get; set; }

		public long TaxPaymentPerMonth()
		{
			return (long)(1.0 * QuotaHoursPerMonth.HoursPerMonth *
			              PaymentPerHour *
			              WorkersNumber *
			              IncomeTax);
		}

		public override string ToString()
		{
			return $"{CompanyName}\n{WorkersNumber}\n{PaymentPerHour}\n{IncomeTax}\n{QuotaHoursPerMonth}";
		}

		public void SaveToFile(string path)
		{
			using (StreamWriter writer = new StreamWriter(path))
			{
				writer.Write(Instance.ToString());
			}
		}

		public void LoadFromFile(string path)
		{
			using (StreamReader reader = new StreamReader(path))
			{
				Parse(reader.ReadToEnd());
			}
		}

	}
}
