using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem245
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetMinimumNumberOfJumpsToEnd_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<int> { 6, 2, 4, 0, 5, 1, 1, 4, 2, 9 };
			var expectedResult = 2;

			// Act
			var actualResult = Solution.GetMinimumNumberOfJumpsToEnd(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
