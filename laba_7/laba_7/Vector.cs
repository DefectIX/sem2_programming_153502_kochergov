//
// ReSharper disable ArrangeAccessorOwnerBody
// ReSharper disable ConvertToAutoProperty
// ReSharper disable PossibleNullReferenceException
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
	public class Vector
	{
		protected bool Equals(Vector other)
		{
			return this == other;
		}

		public const int Precision = 10;

		public double A { get; set; }

		public double B { get; set; }

		public double C { get; set; }

		public Vector(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}

		public static Vector operator +(Vector lhs, Vector rhs)
		{
			return new Vector(lhs.A + rhs.A, lhs.B + rhs.B, lhs.C + rhs.C);
		}

		public static Vector operator -(Vector lhs, Vector rhs)
		{
			return new Vector(lhs.A - rhs.A, lhs.B - rhs.B, lhs.C - rhs.C);
		}

		public static Vector operator ++(Vector vec)
		{
			return new Vector(vec.A + 1, vec.B + 1, vec.C + 1);
		}

		public static Vector operator --(Vector vec)
		{
			return new Vector(vec.A - 1, vec.B - 1, vec.C - 1);
		}

		public static Vector operator *(Vector lhs, Vector rhs)
		{
			return new Vector(lhs.A * rhs.A, lhs.B * rhs.B, lhs.C * rhs.C);
		}

		public static Vector operator *(Vector lhs, double rhs)
		{
			return new Vector(lhs.A * rhs, lhs.B * rhs, lhs.C * rhs);
		}

		public static Vector operator /(Vector lhs, double rhs)
		{
			return new Vector(lhs.A / rhs, lhs.B / rhs, lhs.C / rhs);
		}

		public static bool operator ==(Vector lhs, Vector rhs)
		{
			return Math.Abs(lhs.A - rhs.A) < Math.Pow(10, -Precision) &&
				   Math.Abs(lhs.B - rhs.B) < Math.Pow(10, -Precision) &&
				   Math.Abs(lhs.C - rhs.C) < Math.Pow(10, -Precision);
		}

		public static bool operator !=(Vector lhs, Vector rhs)
		{
			return !(lhs == rhs);
		}

		public static bool operator true(Vector vec)
		{
			return vec.A != 0 || vec.B != 0 || vec.C != 0;
		}

		public static bool operator false(Vector vec)
		{
			return vec.A == 0 && vec.B == 0 && vec.C == 0;
		}

		public static explicit operator double(Vector vec)
		{
			return Math.Sqrt(vec.A * vec.A + vec.B * vec.B + vec.C * vec.C);
		}

		public static explicit operator Vector(double a)
		{
			return new Vector(a, 0, 0);
		}

		public override string ToString()
		{
			return "(" + A + ", " + B + ", " + C + ")";
		}
	}
}
