using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem166
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[]
			{
				new int[] {1, 2},
				new int[] {3},
				new int[] { },
				new int[] {4, 5, 6},
			};

			var iterator = new TwoDIterator(input);

			var expectedResult = new List<int> {1, 2, 3, 4, 5, 6};

			// Act
			var actualResult = iterator.ToList();

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
