using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblem.Tests.Problem81Tests
{
	[TestFixture]
	public class GetPossibleLettersTests
	{
		[Test]
		public void TestGetPossibleLetters_ShouldReturnCorrectly()
		{
			// Arrange
			var mappings = new Dictionary<char, string[]> {
		{ '2', new string[] { "a", "b", "c" } },
		{ '3', new string[] { "d", "e", "f" } }
	  };

			var inputNumber = "23";

			var expectedResult = new string[] {
		"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"
	  };

			// Act
			var actualResult = Solutions.Problem81.Solution.GetPossibleLetters(inputNumber, mappings);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actualResult);
		}
	}
}
