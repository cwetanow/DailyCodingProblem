using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem63Tests
{
	[TestFixture]
	public class SolutionTests
	{
		[TestCase("MASS")]
		[TestCase("NOB")]
		[TestCase("OBQ")]
		[TestCase("BNA")]
		[TestCase("CQO")]
		[TestCase("FOAM")]
		public void TestProblem63Solution_WordExists_ShouldReturnTrue(string word)
		{
			// Arrange
			var matrix = new char[][]{
		new char[]{'F', 'A', 'C', 'I'},
		new char[]{'O', 'B', 'Q', 'P'},
		new char[]{'A', 'N', 'O', 'B'},
		new char[]{ 'M', 'A', 'S', 'S' }
	  };

			// Act
			var result = Solutions.Problem63.Solution.CanWordBeFound(matrix, word);

			// Assert
			Assert.IsTrue(result);
		}

		[TestCase("TEST")]
		[TestCase("NOTEXISTINGWORD")]
		public void TestProblem63Solution_WordDoesNotExist_ShouldReturnFalse(string word)
		{
			// Arrange
			var matrix = new char[][]{
		new char[]{'F', 'A', 'C', 'I'},
		new char[]{'O', 'B', 'Q', 'P'},
		new char[]{'A', 'N', 'O', 'B'},
		new char[]{ 'M', 'A', 'S', 'S' }
	  };

			// Act
			var result = Solutions.Problem63.Solution.CanWordBeFound(matrix, word);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
