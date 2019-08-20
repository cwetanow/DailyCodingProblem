using System;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem273
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetFixedPoint_ThereIsFixedPoint_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] { -6, 0, 2, 40 };
			var expectedResult = 2;

			// Act
			var actual = Solution.GetFixedPoint(input);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}

		[Test]
		public void TestGetFixedPoint_ThereIsNoFixedPoint_ShouldReturnNull()
		{
			// Arrange
			var input = new[] { 1, 5, 7, 8 };

			// Act
			var actual = Solution.GetFixedPoint(input);

			// Assert
			Assert.IsNull(actual);
		}
	}
}
