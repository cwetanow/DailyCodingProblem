using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem138
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindMinimumNumberOfCoinsToSumN_ShouldReturnCorrectly()
		{
			// Arrange
			var n = 16;
			var expectedResult = new List<int> {10, 5, 1};

			// Act
			var actualResult = Solution.FindMinimumNumberOfCoinsToSumN(n);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
