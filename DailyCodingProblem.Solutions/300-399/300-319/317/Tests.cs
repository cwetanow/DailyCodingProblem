using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem317
{
	[TestFixture]
	public class Tests
	{
		[TestCase(4, 13, 0)]
		public void TestGetBitwiseAnd_ShouldReturnCorrectly(int m, int n, int expectedResult)
		{
			// Arrange, Act
			var actual = Solution.GetBitwiseAnd(m, n);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
