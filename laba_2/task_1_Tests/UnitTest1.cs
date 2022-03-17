using System;
using Xunit;
using task_1;

namespace task_1_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(10, false)]
		[InlineData(50, false)]
		[InlineData(51, true)]
		[InlineData(99, true)]
		public void Test1_IsSumOfDigitsEven(int a, bool expected)
		{
			Assert.Equal(Program.IsSumOfDigitsEven(a), expected);
		}
	}
}
