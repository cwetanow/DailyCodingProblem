using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem140
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindElementsThatAppearOnce_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<int> { 2, 4, 6, 8, 10, 2, 6, 10 };
			var expectedResult = new List<int> { 4, 8 };

			// Act
			var actualResult = Solution.FindElementsThatAppearOnce(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
