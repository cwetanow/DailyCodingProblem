using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem158
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetWaysToReachBottomRight_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[]
			{
				new[] {0, 0, 1},
				new[] {0, 0, 1},
				new[] {1, 0, 0}
			};

			var rows = 3;
			var cols = 3;

			var expectedResult = 2;

			// Act
			var actualResult = Solution.GetWaysToReachBottomRight(input, rows, cols);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
