//
// ReSharper disable FieldCanBeMadeReadOnly.Local
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	public class NoBonus : IPayment
	{
		public NoBonus(long payment)
		{
			_payment = payment;
		}

		private long _payment;

		public long GetPayment()
		{
			return _payment;
		}
	}
}
