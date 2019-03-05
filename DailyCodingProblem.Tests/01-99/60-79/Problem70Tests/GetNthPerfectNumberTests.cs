using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem70Tests
{
	[TestFixture]
	public class GetNthPerfectNumberTests
	{
		[TestCase(1, 19)]
		[TestCase(2, 28)]
		[TestCase(10, 109)]
		[TestCase(36, 370)]
		public void TestGetNthPerfectNumber_ShouldReturnCorrectly(int n, int expectedResult)
		{
			// Arrange, Act
			var result = Solutions.Problem70.Solution.GetNthPerfectNumber(n);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
