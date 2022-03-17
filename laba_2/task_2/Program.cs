/*
 
Variant 12
-50 <= x <= 50
-25 <= y <= 25

 */

using System;

namespace task_2
{
	public class Program
	{
		public enum PointState
		{
			InRegion,
			OutsideRegion,
			OnBorder
		}
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
				Console.WriteLine("Enter x:");
				var x = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter y:");
				var y = int.Parse(Console.ReadLine());
				switch (IsPointContainedByRegion(x, y))
				{
					case PointState.InRegion:
						Console.WriteLine("Да");
						break;
					case PointState.OutsideRegion:
						Console.WriteLine("Нет");
						break;
					case PointState.OnBorder:
						Console.WriteLine("На границе");
						break;
				}
			}
		}
		public static PointState IsPointContainedByRegion(int x, int y)
		{
			if (Math.Abs(x) <= 50 && Math.Abs(y) <= 25)
			{
				if (Math.Abs(x) == 50 || Math.Abs(y) == 25)
					return PointState.OnBorder;
				return PointState.InRegion;
			}
			return PointState.OutsideRegion;
		}

	}
}
