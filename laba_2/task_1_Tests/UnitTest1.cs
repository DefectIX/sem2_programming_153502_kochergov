using System;
using Xunit;

namespace task_1_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(10, false)]
		[InlineData(50, false)]
		[InlineData(51, true)]
		[InlineData(99, true)]
		public void Test1lIsSumOfDigitsEven_Test(int a, bool expected)
		{
			Assert.Equal(task_1.Program.IsSumOfDigitsEven(a), expected);
		}
	}
}
