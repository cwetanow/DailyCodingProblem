using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem184
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TesFindGreatestCommonDenominator_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] { 42, 56, 14};
			var expectedResult = 14;

			// Act
			var result = Solution.FindGreatestCommonDenominator(input);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
