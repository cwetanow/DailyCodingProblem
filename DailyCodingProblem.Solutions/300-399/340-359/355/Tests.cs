using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem355
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestRoundArrayToSmallestDifferenceWithEqualSums_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] { 1.3, 2.3, 4.4 };
			var expectedResult = new[] {1, 2, 5};

			// Act
			var actualResult = Solution.RoundArrayToSmallestDifferenceWithEqualSums(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
