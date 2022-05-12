using System;
using Xunit;
using laba_7;

namespace laba_7_tests
{
	public class VectorTests
	{
		[Theory]
		[InlineData(0, 0, 0, 0, 0, 0)]
		[InlineData(1, 5, 9, 2, 8, 17)]
		[InlineData(1e3, -1e3, 1e3, 1e3, 1e3, 1e3)]
		public void BinOpVectorPlusVectorTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Vector result = v1 + v2;

			Assert.Equal(a1 + a2, result.A);
			Assert.Equal(b1 + b2, result.B);
			Assert.Equal(c1 + c2, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, 0, 0)]
		[InlineData(1, 5, 9, 2, 8, 17)]
		[InlineData(1e3, -1e3, 1e3, 1e3, 1e3, 1e3)]
		public void BinOpVectorMinusVectorTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Vector result = v1 - v2;

			Assert.Equal(a1 - a2, result.A);
			Assert.Equal(b1 - b2, result.B);
			Assert.Equal(c1 - c2, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, 0, 0)]
		[InlineData(1, 5, 9, 2, 8, 17)]
		[InlineData(1e3, -1e3, 1e3, 1e3, 1e3, 1e3)]
		public void BinOpVectorMultiplyVectorTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Vector result = v1 * v2;

			Assert.Equal(a1 * a2, result.A);
			Assert.Equal(b1 * b2, result.B);
			Assert.Equal(c1 * c2, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(1, 5, 9, 2)]
		[InlineData(1e3, -1e3, 1e3, 1e3)]
		public void BinOpVectorMultiplyDoubleTest(double a1, double b1, double c1, double number)
		{
			Vector v1 = new Vector(a1, b1, c1);

			Vector result = v1 * number;

			Assert.Equal(a1 * number, result.A);
			Assert.Equal(b1 * number, result.B);
			Assert.Equal(c1 * number, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(1, 5, 9, 2)]
		[InlineData(1e3, -1e3, 1e3, 1e3)]
		public void BinOpVectorDivideDoubleTest(double a1, double b1, double c1, double number)
		{
			Vector v1 = new Vector(a1, b1, c1);

			Vector result = v1 / number;

			Assert.Equal(a1 / number, result.A);
			Assert.Equal(b1 / number, result.B);
			Assert.Equal(c1 / number, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(1, 5, 9)]
		[InlineData(1e3, -1e3, 1e3)]
		public void UnOpIncreaseTest(double a1, double b1, double c1)
		{
			Vector v1, result;

			v1 = new Vector(a1, b1, c1);
			result = ++v1;
			Assert.Equal(a1 + 1, result.A);
			Assert.Equal(b1 + 1, result.B);
			Assert.Equal(c1 + 1, result.C);

			v1 = new Vector(a1, b1, c1);
			result = v1++;
			Assert.Equal(a1, result.A);
			Assert.Equal(b1, result.B);
			Assert.Equal(c1, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(1, 5, 9)]
		[InlineData(1e3, -1e3, 1e3)]
		public void UnOpDecreaseTest(double a1, double b1, double c1)
		{
			Vector v1, result;

			v1 = new Vector(a1, b1, c1);
			result = --v1;
			Assert.Equal(a1 - 1, result.A);
			Assert.Equal(b1 - 1, result.B);
			Assert.Equal(c1 - 1, result.C);

			v1 = new Vector(a1, b1, c1);
			result = v1--;
			Assert.Equal(a1, result.A);
			Assert.Equal(b1, result.B);
			Assert.Equal(c1, result.C);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, 0, 0)]
		[InlineData(17, 17, 17, 17, 17, 17)]
		[InlineData(1e3, 1e3, 1e3, 1e3, 1e3, 1e3)]
		public void BinOpVectorEqualsVectorTrueTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Assert.True(v1 == v2);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, -1, 0)]
		[InlineData(17, 3, 17, 17, 17, 17)]
		[InlineData(1e3, 1e3, 1, 1e3, 1e3, 1e3)]
		public void BinOpVectorEqualsVectorFalseTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Assert.False(v1 == v2);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, -1, 0)]
		[InlineData(17, 3, 17, 17, 17, 17)]
		[InlineData(1e3, 1e3, 1, 1e3, 1e3, 1e3)]
		public void BinOpVectorNotEqualsVectorTrueTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Assert.True(v1 != v2);
		}

		[Theory]
		[InlineData(0, 0, 0, 0, 0, 0)]
		[InlineData(17, 17, 17, 17, 17, 17)]
		[InlineData(1e3, 1e3, 1e3, 1e3, 1e3, 1e3)]
		public void BinOpVectorNotEqualsVectorFalseTest(double a1, double b1, double c1, double a2, double b2, double c2)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Vector v2 = new Vector(a2, b2, c2);

			Assert.False(v1 != v2);
		}

		[Fact]
		public void UnOpTrueFalseTest()
		{
			Vector v1 = new Vector(0, 0, 0);
			Vector v2 = new Vector(1, 0, 0);
			Vector v3 = new Vector(0, 1, 0);
			Vector v4 = new Vector(0, 0, 1);
			bool result;
			result = v1 ? true : false;
			Assert.False(result);

			result = v2 ? true : false;
			Assert.True(result);

			result = v3 ? true : false;
			Assert.True(result);

			result = v4 ? true : false;
			Assert.True(result);
		}

		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(1, 5, 9, 10.34408043278)]
		[InlineData(1e3, -1e3, 1e3, 1732.05080756887)]
		public void UnOpVectorToDoubleTest(double a1, double b1, double c1, double expected)
		{
			Vector v1 = new Vector(a1, b1, c1);
			Assert.Equal(expected, (double)v1, Vector.Precision);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(19)]
		[InlineData(1e3)]
		public void UnOpDoubleToVectorTest(double number)
		{
			Vector v1 = (Vector)number;
			Assert.Equal(number, v1.A);
			Assert.Equal(0, v1.B);
			Assert.Equal(0, v1.C);
		}

	}
}
