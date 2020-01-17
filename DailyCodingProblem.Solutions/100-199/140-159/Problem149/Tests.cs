using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem149
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetSublistSum_ShouldReturnCorrectly()
		{
			// Arrange
			var list = new List<int> { 1, 2, 3, 4, 5 };
			var start = 1;
			var end = 3;

			var expectedResult = 5;

			var sut = new Solution(list);

			// Act
			var actualResult = sut.GetSublistSum(start, end);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
