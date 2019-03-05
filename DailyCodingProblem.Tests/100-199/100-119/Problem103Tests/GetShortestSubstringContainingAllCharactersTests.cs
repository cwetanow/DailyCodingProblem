using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem103Tests
{
	[TestFixture]
	public class GetShortestSubstringContainingAllCharactersTests
	{
		[Test]
		public void TestGetShortestSubstringContainingAllCharacters_ShouldReturnCorrectly()
		{
			// Arrange
			var input = "figehaeci";
			var characters = new char[] { 'a', 'e', 'i' };
			var expectedResult = "aeci";

			// Act

			var shortestSubstring = Solutions.Problem103.Solution.GetShortestSubstringContainingAllCharacters(input, characters);

			// Assert
			Assert.AreEqual(expectedResult, shortestSubstring);
		}

		[Test]
		public void TestGetShortestSubstringContainingAllCharacters_ThereIsNoSubstring_ShouldReturnNull()
		{
			// Arrange
			var input = "test";
			var characters = new char[] { 'a' };

			// Act

			var shortestSubstring = Solutions.Problem103.Solution.GetShortestSubstringContainingAllCharacters(input, characters);

			// Assert
			Assert.IsNull(shortestSubstring);
		}
	}
}
