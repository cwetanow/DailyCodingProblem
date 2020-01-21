using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem167
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetPairsOfUniqueIndicesWithConcatenationOfWordsIsPalindrome_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<string> { "code", "edoc", "da", "d" };
			var expectedResult = new List<(int first, int second)> { (0, 1), (1, 0), (2, 3) };

			// Act
			var actualResult = Solution.GetPairsOfUniqueIndicesWithConcatenationOfWordsIsPalindrome(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
