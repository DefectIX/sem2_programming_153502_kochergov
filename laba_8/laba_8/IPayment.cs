using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
	interface IPayment
	{
		double GetPayment(bool mustIgnoreBonus = false);
	}
}
