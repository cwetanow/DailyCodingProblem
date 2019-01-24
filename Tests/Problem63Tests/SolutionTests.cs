using NUnit.Framework;
using Problem63;

namespace Tests.Problem63Tests
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
			var result = Program.CanWordBeFound(matrix, word);

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
			var result = Program.CanWordBeFound(matrix, word);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
