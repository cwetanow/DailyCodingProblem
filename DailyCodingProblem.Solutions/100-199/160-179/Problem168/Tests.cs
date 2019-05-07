using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem168
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestRotate_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			var expectedResult = new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };

			// Act
			var result = Solution.Rotate(input);

			// Assert
			CollectionAssert.AreEqual(expectedResult, result);
		}
	}
}
