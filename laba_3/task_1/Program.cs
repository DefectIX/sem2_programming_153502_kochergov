//Variant 6

using System;

namespace task_1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter positive integer number n: ");
			uint n = uint.Parse(Console.ReadLine());
			Console.Write("Enter number x: ");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("\n(x^n)/n == {0:0.###}", f(n, x));

			Console.WriteLine("\n(x^2)/2 + (x^4)/4 + (x^6)/6 == {0:0.###}",
				f(2, x) + f(4, x) + f(6, x));
		}

		public static double f(uint n, double x)
		{
			return Math.Pow(x, n) / n;
		}
	}
}
