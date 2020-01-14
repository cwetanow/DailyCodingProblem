using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem270
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetMessagePropagationTime_ShouldReturnCorrectly()
		{
			// Arrange
			var edges = new List<(int start, int finish, int time)>
			{
				(0, 1, 5),
				(0, 2, 3),
				(0, 5, 4),
				(1, 3, 8),
				(2, 3, 1),
				(3, 5, 10),
				(3, 4, 5)
			};
			var n = 5;

			var expectedResult = 9;

			// Act
			var actualResult = Solution.GetMessagePropagationTime(edges, n);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
