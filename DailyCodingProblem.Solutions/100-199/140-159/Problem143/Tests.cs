using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem143
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestPartitionList_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<int> { 9, 12, 3, 5, 14, 10, 10 };
			var x = 10;

			var expectedResult = new List<int> { 9, 3, 5, 10, 10, 12, 14 };

			// Act
			var actualResult = Solution.PartitionList(input, x);

			// Assert
			actualResult.Should().ContainInOrder(expectedResult);
		}
	}
}
