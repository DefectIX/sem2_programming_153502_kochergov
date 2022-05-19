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
		public NoBonus(double payment)
		{
			_payment = payment;
		}

		private double _payment;

		public double GetPayment(bool mustIgnoreBonus)
		{
			return _payment;
		}
	}
}
