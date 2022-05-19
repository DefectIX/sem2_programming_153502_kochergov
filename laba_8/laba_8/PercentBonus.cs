//
// ReSharper disable FieldCanBeMadeReadOnly.Local
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	public class PercentBonus : IPayment
	{
		public PercentBonus(double payment, double bonus)
		{
			_payment = payment;
			_bonus = bonus;
		}

		private double _payment;
		private double _bonus;

		public double GetPayment()
		{
			return _payment * (1 + _bonus * 0.01);
		}
	}
}
