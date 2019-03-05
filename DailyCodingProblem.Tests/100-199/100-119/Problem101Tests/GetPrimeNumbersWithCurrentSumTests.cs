using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem101Tests
{
	[TestFixture]
	public class GetPrimeNumbersWithCurrentSumTests
	{
		[TestCase(4, 2, 2)]
		public void TestGetPrimeNumbersWithCurrentSum_ShouldReturnCorrectly(int input, int expectedLeft, int expectedRight)
		{
			// Arrange, Act
			var (left, right) = Solutions.Problem101.Solution.GetPrimeNumbersWithSum(input);

			// Assert
			Assert.AreEqual(expectedLeft, left);
			Assert.AreEqual(expectedRight, right);
		}
	}
}
