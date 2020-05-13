using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem42
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetSubsetsThatAddsToK_ShouldReturnCorrectly()
		{
			// Arrange
			var s = new List<int> { 12, 1, 61, 5, 9, 2 };
			var k = 24;

			var expected = new List<int> { 12, 9, 2, 1 };

			// Act
			var actual = Solution.GetSubsetThatAddsToK(s, k);

			// Assert
			actual.Should().BeEquivalentTo(expected);
		}
	}
}
