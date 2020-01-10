using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem332
{
	[TestFixture]
	public class Tests
	{
		[TestCase(5, 5, 2)]
		public void TestGetNumberOfPairs_ShouldReturnCorrectly(int m, int n, int expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.GetNumberOfPairs(m, n);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
