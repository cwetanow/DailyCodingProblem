using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem118Tests
{
	[TestFixture]
	public class GetSquaredSortedElementsTests
	{
		[Test]
		public void TestGetSquaredSortedElements_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new int[] { -9, -2, 0, 2, 3 };

			var expectedResult = new int[] { 0, 4, 4, 9, 81 };

			// Act
			var actualResult = DailyCodingProblem.Solutions.Problem118.Solution.GetSquaredSortedElements(input);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actualResult);
		}
	}
}
