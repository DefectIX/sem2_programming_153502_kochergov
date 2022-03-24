using System;

namespace task_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter date in format \'dd.mm.yyyy\':");
			int dayOfWeek = DateService.GetDay(Console.ReadLine());
			Console.Write("Day of week: ");
			switch (dayOfWeek)
			{
				case 0:
					Console.WriteLine("Monday");
					break;
				case 1:
					Console.WriteLine("Tuesday");
					break;
				case 2:
					Console.WriteLine("Wednesday");
					break;
				case 3:
					Console.WriteLine("Thursday");
					break;
				case 4:
					Console.WriteLine("Friday");
					break;
				case 5:
					Console.WriteLine("Saturday");
					break;
				case 6:
					Console.WriteLine("Sunday");
					break;
			}
			Console.Write("\nEnter day: ");
			int day = int.Parse(Console.ReadLine());
			Console.Write("Enter month: ");
			int month = int.Parse(Console.ReadLine());
			Console.Write("Enter year: ");
			int year = int.Parse(Console.ReadLine());
			Console.WriteLine("Number of days between this date and current date: " + DateService.GetDaysSpan(day, month, year));
		}
	}
}
