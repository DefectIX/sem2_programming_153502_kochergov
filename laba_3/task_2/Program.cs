//Variant 2

using System;
using task_2.Services;

namespace task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter integer number a: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Enter integer number b: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Enter integer number z: ");
			int z = int.Parse(Console.ReadLine());
			int branch;
			Console.Write("Result: y={0:0.####}.\nCalculations went on branch #", Task2.Y(a, b, z, out branch));
			if (branch == 1)
				Console.WriteLine("1 (z < a*b)");
			else
				Console.WriteLine("2 (z >= a*b)");
		}
	}
}
