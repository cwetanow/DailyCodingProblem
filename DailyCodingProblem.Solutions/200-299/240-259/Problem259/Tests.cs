using System.Collections.Generic;
using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem259
{
	[TestFixture]
	public class Tests
	{
		[TestCase(1, new[] { "cat", "calf", "dog", "bear" }, new[] { 'b' })]
		public void TestGetStartLetters_ShouldReturnCorrectly(int id, string[] letters, char[] expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.GetStartLetters(letters);

			// Assert
			CollectionAssert.AreEquivalent(expectedResult, actualResult);
		}
	}
}
