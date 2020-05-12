using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem314
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetMinimumBroadcastRange_ShouldReturnCorrectly()
		{
			// Arrange
			var listeners= new List<int> { 1, 5, 11, 20 };
			var towers= new List<int?> { 4, 8, 15 };
			var expectedMinimumRange = 5;

			// Act
			var actualMinimumRange = Solution.GetMinimumBroadcastRange(listeners, towers);

			// Assert
			actualMinimumRange.Should().Be(expectedMinimumRange);
		}
	}
}
