using System;

namespace laba_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector v1 = new Vector(2, 3, 5);
			Vector v2 = new Vector(1, 2, 3);
			Vector v3 = new Vector(0, 0, 0);
			Vector v4 = new Vector(0, 0, 0);
			Vector result;
			Console.WriteLine("v1 = " + v1);
			Console.WriteLine("v2 = " + v2);
			Console.WriteLine("v3 = " + v3);
			Console.WriteLine("v4 = " + v4 + "\n");

			result = v1 + v2;
			Console.WriteLine("v1 + v2 = " + result);

			result = v1 - v2;
			Console.WriteLine("v1 - v2 = " + result);

			result = v1 * v2;
			Console.WriteLine("v1 * v2 = " + result);

			result = v1 * 2;
			Console.WriteLine("v1 * 2 = " + result);

			result = v1 / 2;
			Console.WriteLine("v1 / 2 = " + result);

			Console.WriteLine("v3 == v2: " + (v3 == v2));
			Console.WriteLine("v3 == v4: " + (v3 == v4));

			Console.WriteLine("v3 != v2: " + (v3 != v2));
			Console.WriteLine("v3 != v4: " + (v3 != v4));


			Console.WriteLine(v1 ? "v1  = true" : "v1  = false");
			Console.WriteLine(v3 ? "v3  = true" : "v3  = false");

			Console.WriteLine("(double)v1 = " + (double)v1);
			Console.WriteLine("(Vector)10 = " + (Vector)10);

		}
	}
}
