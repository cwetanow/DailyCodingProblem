using System.Collections.Generic;
using System.Collections.Specialized;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem226
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetOrderedLetters_ShouldReturnCorrectly()
		{
			// Arrange
			var orderedWords = new List<string> { "xww", "wxyz", "wxyw", "ywx", "ywz" };

			var expectedLetters = new List<char> { 'x', 'z', 'w', 'y' };

			// Act
			var actual = Solution.GetOrderedLetters(orderedWords);

			// Assert
			actual.Should().BeEquivalentTo(expectedLetters);
		}
	}
}
