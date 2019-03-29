using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem129Tests
{
	[TestFixture]
	public class GetSquareRootTests
	{
		[TestCase(9, 3)]
		public void TestGetSquareRoot_ShouldReturnCorrectly(int input, int expectedResult)
		{
			// Arrange, Act
			var actual = Solutions.Problem129.Solution.GetSquareRoot(input);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
