using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem295
{
	[TestFixture]
	public class Tests
	{
		[TestCase(1, new[] { 1 })]
		[TestCase(2, new[] { 1, 1 })]
		[TestCase(3, new[] { 1, 2, 1 })]
		[TestCase(4, new[] { 1, 3, 3, 1 })]
		[TestCase(5, new[] { 1, 4, 6, 4, 1 })]
		public void TestGetKthRow_ShouldReturnCorrectly(int k, int[] expectedResult)
		{
			// Arrange, Act
			var result = Solution.GetKthRow(k);

			// Assert
			CollectionAssert.AreEqual(expectedResult, result);
		}
	}
}
