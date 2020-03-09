using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem321
{
	[TestFixture]
	public class Tests
	{
		[TestCase(100,5)]
		public void TestFindSmallestNumberOfStepsToReachOne_ShouldReturnCorrectly(int n, int expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.FindSmallestNumberOfStepsToReachOne(n);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
