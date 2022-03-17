//Variant 9

using System;

namespace task_1
{
	public class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int input;
				Console.WriteLine("Enter 1 if you want continue, 2 if you want to exit");
				input = int.Parse(Console.ReadLine());
				switch (input)
				{
					case 1:
						break;
					default:
						return;
				}
				Console.WriteLine("Enter two-digit number:");
				input = int.Parse(Console.ReadLine());
				if (IsSumOfDigitsEven(input))
					Console.WriteLine("Сумма цифр двухзначного числа является четной");
				else
					Console.WriteLine("Сумма цифр двухзначного числа не является четной");
			}
		}

		public static bool IsSumOfDigitsEven(int a)
		{
			var digitsSum = (a / 10 + a % 10) % 2;
			return digitsSum % 2 == 0;
		}
	}
}
