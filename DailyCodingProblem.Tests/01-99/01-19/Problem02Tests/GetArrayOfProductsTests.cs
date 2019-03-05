using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem02Tests
{
	[TestFixture]
	public class GetArrayOfProductsTests
	{
		[TestCase(1, new[] { 1, 2, 3, 4, 5 }, new[] { 120, 60, 40, 30, 24 })]
		[TestCase(2, new[] { 3, 2, 1 }, new[] { 2, 3, 6 })]
		public void TestGetArrayOfProducts_ShouldReturnCorrectly(int _, int[] input, int[] expectedResult)
		{
			// Arrange, Act
			var result = DailyCodingProblem.Solutions.Problem02.Solution.GetArrayOfProducts(input);

			// Assert
			CollectionAssert.AreEqual(expectedResult, result);
		}
	}
}
