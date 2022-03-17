using System;
using Xunit;
using task_1;

namespace task_1_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(10, false)]
		[InlineData(11, true)]
		public void Test1_IsSumOfDigitsEven_MinValue(int a, bool expected)
		{
			Assert.Equal(expected, Program.IsSumOfDigitsEven(a));
		}

		[Theory]
		[InlineData(98, false)]
		[InlineData(99, true)]
		public void Test1_IsSumOfDigitsEven_MaxValue(int a, bool expected)
		{
			Assert.Equal(expected, Program.IsSumOfDigitsEven(a));
		}

		[Theory]
		[InlineData(50, false)]
		[InlineData(51, true)]
		public void Test1_IsSumOfDigitsEven_MiddleValue(int a, bool expected)
		{
			Assert.Equal(expected, Program.IsSumOfDigitsEven(a));
		}

	}
}
