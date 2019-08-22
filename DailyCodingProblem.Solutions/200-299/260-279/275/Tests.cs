using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem275
{
	[TestFixture]
	public class Tests
	{
		[TestCase(1, "1")]
		[TestCase(4, "1211")]
		[TestCase(5, "111221")]
		public void TestGetNthTermOfSequence_ShouldReturnCorrectly(int n, string expectedResult)
		{
			// Arrange, Act
			var actual = Solution.GetNthTermOfSequence(n);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
