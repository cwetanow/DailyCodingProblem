using NUnit.Framework;
using System;

namespace DailyCodingProblem.Tests.Problem61Tests
{
	[TestFixture]
	public class PowTests
	{
		[TestCase(2, 10)]
		[TestCase(3, 3)]
		[TestCase(10, 3)]
		public void TestPow_ShouldReturnCorrectly(int number, int power)
		{
			// Arrange
			var expectedResult = Math.Pow(number, power);

			// Arrange, Act
			var result = Solutions.Problem61.Solution.Pow(number, power);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
