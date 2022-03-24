using System;
using Xunit;
using task_1;

namespace test_task_1
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1, 0, 0)]
		[InlineData(1, 1, 1)]
		[InlineData(1, 5, 5)]
		public void F_Test__Min(uint n, double x, double expected)
		{
			Assert.Equal(expected, Program.f(n, x), 8);
		}

		[Theory]
		[InlineData(10, 100, 1e19)]
		public void F_Test__Max(uint n, double x, double expected)
		{
			Assert.Equal(expected, Program.f(n, x), 8);
		}


		[Theory]
		[InlineData(2, 2, 2)]
		[InlineData(4, 12, 5184)]
		[InlineData(6, 2, 32/3.0)]
		public void F_Test__Mid(uint n, double x, double expected)
		{
			Assert.Equal(expected, Program.f(n, x), 8);
		}

	}
}
