using System;
using Xunit;
using task_2.Services;

namespace test_task_2
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1, 1, 0, 1, 0.770151152934069)]
		public void Y_Test__Min(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.Y(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}

		[Theory]
		[InlineData(100, 100, 1e4-1, 1, 93.11594361438)]
		[InlineData(100, 10-1, 1e3-1, 2, 107.55495817997)]
		public void Y_Test__Max(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.Y(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}


		[Theory]
		[InlineData(8, 5, 1e3-1, 2, 9.977753104514)]
		[InlineData(8, 50, 1e2-1, 1, -21.919953428988)]
		public void Y_Test__Mid(int a, int b, int z, int expectedBranch, double expected)
		{
			int actualBranch;
			Assert.Equal(expected, Task2.Y(a, b, z, out actualBranch), 8);
			Assert.Equal(expectedBranch, actualBranch);
		}

	}
}
