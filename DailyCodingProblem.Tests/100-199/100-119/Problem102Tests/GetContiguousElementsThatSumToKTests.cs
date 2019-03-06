using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem102Tests
{
	[TestFixture]
	public class GetContiguousElementsThatSumToKTests
	{
		[Test]
		public void TestGetContiguousElementsThatSumToK_ShouldReturnCorrectly()
		{
			// Arrange
			var k = 9;
			var list = new[] { 1, 2, 3, 4, 5 };

			var expectedResult = new[] { 2, 3, 4 };

			// Act
			var actual = Solutions.Problem102.Solution.GetContiguousElementsThatSumToK(list, k);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actual);
		}
	}
}
