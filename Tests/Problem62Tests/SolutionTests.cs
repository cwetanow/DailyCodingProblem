using NUnit.Framework;
using Problem62;

namespace Tests.Problem62Tests
{
	[TestFixture]
	public class SolutionTests
	{
		[TestCase(2, 2, 2)]
		[TestCase(5, 5, 70)]
		public void TestProblem62Solution_ShouldReturnCorrectResult(int n, int m, int expectedResult)
		{
			// Arrange
			// Act
			var result = Program.GetNumberOfWaysToCorner(n, m);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
