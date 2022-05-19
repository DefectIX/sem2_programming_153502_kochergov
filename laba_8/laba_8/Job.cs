//
// ReSharper disable FieldCanBeMadeReadOnly.Local
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	class Job
	{
		public Job(string name, IPayment payment)
		{
			Name = name;
			_payment = payment;
		}

		public string Name { get; set; }
		private IPayment _payment;
		
		public long GetPayment()
		{
			return _payment.GetPayment();
		}
	}
}
