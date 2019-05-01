using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem163
{
	[TestFixture]
	public class Tests
	{
		[TestCase(8, new object[] { 5, 3, '+' })]
		[TestCase(5, new object[] { 15, 7, 1, 1, '+', '-', '/', 3, '*', 2, 1, 1, '+', '+', '-' })]
		public void TestEvaluateReversePolishNotation_ShouldReturnCorrectly(int expectedResult, object[] items)
		{
			// Arrange, Act
			var result = Solution.EvaluateReversePolishNotation(items);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
