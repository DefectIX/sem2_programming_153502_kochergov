//
// ReSharper disable FieldCanBeMadeReadOnly.Local
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	public class AbsBonus : IPayment
	{
		public AbsBonus(long payment, long bonus)
		{
			_payment = payment;
			_bonus = bonus;
		}

		private long _payment;
		private long _bonus;

		public long GetPayment()
		{
			return _payment + _bonus;
		}
	}
}
