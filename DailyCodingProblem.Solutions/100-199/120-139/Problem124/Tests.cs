using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem124
{
	[TestFixture]
	public class Tests
	{
		[TestCase(50, 6)] // 50->25->13->7->4->2->1
		[TestCase(51, 6)] // 51->26 (left)->13->7->4->2->1
		public void TestGetNumberOfRoundsUntillOneCoinLeft_ShouldReturnCorrectly(int n, int expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.GetNumberOfRoundsUntillOneCoinLeft(n);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
