using NUnit.Framework;

namespace Tests.Problem75Tests
{
	[TestFixture]
	public class GetLongestIncreasingSubsequenceTests
	{
		[Test]
		public void TestGetLongestIncreasingSubsequence_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
			var expectedResult = new int[] { 0, 2, 6, 9, 11, 15 };

			// Act
			var actualResult = Problem75.Program.GetLongestIncreasingSubsequence(input);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actualResult);
		}
	}
}
