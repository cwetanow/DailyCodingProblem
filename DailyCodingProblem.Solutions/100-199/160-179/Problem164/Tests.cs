using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem164
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindDuplicate_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] { 1, 2, 3, 4, 4 };
			var expectedResult = 4;

			// Act
			var result = Solution.FindDuplicate(input);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
