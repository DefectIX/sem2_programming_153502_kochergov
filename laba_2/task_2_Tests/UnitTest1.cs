using System;
using Xunit;
using task_2;

namespace task_2_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(0, 0, Program.PointState.InRegion)]
		[InlineData(10, 10, Program.PointState.InRegion)]
		public void Test1_IsPointContainedByRegion_InRegion(int x, int y, Program.PointState expected)
		{
			Assert.Equal(Program.IsPointContainedByRegion(x, y), expected);
		}

		[Theory]
		[InlineData(50, 50, Program.PointState.OutsideRegion)]
		[InlineData(-50, -50, Program.PointState.OutsideRegion)]
		public void Test1_IsPointContainedByRegion_OutsideRegion(int x, int y, Program.PointState expected)
		{
			Assert.Equal(Program.IsPointContainedByRegion(x, y), expected);
		}

		[Theory]
		[InlineData(50, -25, Program.PointState.OnBorder)]
		[InlineData(50, 0, Program.PointState.OnBorder)]
		[InlineData(0, 25, Program.PointState.OnBorder)]
		public void Test1_IsPointContainedByRegion_OnBorder(int x, int y, Program.PointState expected)
		{
			Assert.Equal(Program.IsPointContainedByRegion(x, y), expected);
		}

	}
}
