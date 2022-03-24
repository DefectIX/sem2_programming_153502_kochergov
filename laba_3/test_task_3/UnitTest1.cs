using System;
using Xunit;
using task_3;

namespace test_task_3
{
	public class DateServiceTests
	{
		[Fact]
		public void GetDay_Test()
		{
			string dateString = DateTime.Now.ToString("dd.MM.yyyy");
			int expected = ((int)DateTime.Now.DayOfWeek + 6) % 7;
			Assert.Equal(expected, DateService.GetDay(dateString));
		}

		[Theory]
		[InlineData(1)]
		[InlineData(50)]
		[InlineData(400)]
		[InlineData(-400)]
		public void GetDaysSpan_Test(int daysNumber)
		{
			DateTime date = DateTime.Now.AddDays(daysNumber);
			int expected = Math.Abs(daysNumber);
			Assert.Equal(expected, DateService.GetDaysSpan(date.Day, date.Month, date.Year));
		}
	}
}
