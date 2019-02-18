using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem85Tests
{
	[TestFixture]
	public class GetNumberTests
	{
		[TestCase(2, 15)]
		[TestCase(1, 5)]
		[TestCase(6, 42)]
		public void TestGetNumber_BIsOne_ShouldReturnX(int x, int y)
		{
			// Arrange
			var b = 1;

			// Act
			var result = Solutions.Problem85.Solution.GetNumber(b, x, y);

			// Assert
			Assert.AreEqual(x, result);
		}

		[TestCase(2, 15)]
		[TestCase(1, 5)]
		[TestCase(6, 42)]
		public void TestGetNumber_BIsZero_ShouldReturnY(int x, int y)
		{
			// Arrange
			var b = 0;

			// Act
			var result = Solutions.Problem85.Solution.GetNumber(b, x, y);

			// Assert
			Assert.AreEqual(y, result);
		}
	}
}
