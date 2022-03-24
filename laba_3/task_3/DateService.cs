using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
	public static class DateService
	{
		public static int GetDay(string dateString)
		{
			CultureInfo provider = CultureInfo.InvariantCulture;
			DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", provider);
			return ((int)date.DayOfWeek + 6) % 7;
		}

		public static int GetDaysSpan(int day, int month, int year)
		{
			DateTime date = new DateTime(year, month, day);
			DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			return Math.Abs((int)date.Subtract(now).TotalDays);
		}
	}
}
