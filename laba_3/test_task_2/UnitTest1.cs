using System;
using Xunit;
using task_2.Services;

namespace test_task_2
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(0, 0, 0, 2, 0)]
		[InlineData(1, 1, 0, 1, 1)]
		public void Y_Test__Min(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.X(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}

		[Theory]
		[InlineData(100, 100, 1e4-1, 1, 10000)]
		[InlineData(100, 10-1, 1e3-1, 2, 899100.0007001715)]
		public void Y_Test__Max(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.X(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}


		[Theory]
		[InlineData(8, 5, 1e3-1, 2, 39960.00070017143)]
		[InlineData(8, 50, 1e2-1, 1, 497.55803681580704)]
		public void Y_Test__Mid(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.X(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}

	}
}
