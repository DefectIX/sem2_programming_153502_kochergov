using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2.Services
{
	public class Task2
	{
		public static double Y(int a, int b, int z, out int branch)
		{
			double x = X(a, b, z, out branch);
			return (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);
		}

		public static double X(int a, int b, int z, out int branch)
		{
			if (z < a * b)
			{
				branch = 1;
				return Math.Sqrt(a * a + b * b * z);
			}
			else
			{
				branch = 2;
				return Math.Pow(Math.Sin(z), 2) + Math.Abs(a * b * z);
			}
		}
	}
}
