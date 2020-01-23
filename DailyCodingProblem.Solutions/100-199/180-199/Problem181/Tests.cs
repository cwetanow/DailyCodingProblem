using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem181
{
	[TestFixture]
	public class Tests
	{
		[TestCase("racecarannakayak", new[] { "racecar", "anna", "kayak" })]
		[TestCase("abc", new[] { "a", "b", "c" })]
		public void TestSplitToFewestPalindromes_ShouldReturnCorrectly(string input, IEnumerable<string> expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.SplitToFewestPalindromes(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
