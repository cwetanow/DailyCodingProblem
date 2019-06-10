using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem195
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TesFindNumberOfElementsBetween_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] {
				new int[] {1, 3, 7, 10, 15, 20 },
				new int[] {2, 6, 9, 14, 22, 25 },
				new int[] { 3, 8, 10, 15, 25, 30},
				new int[] {10, 11, 12, 23, 30, 35 },
				new int[] {20, 25, 30, 35, 40, 45 },
			};

			var i1 = 1;
			var j1 = 1;
			var i2 = 3;
			var j2 = 3;

			var expectedResult = 14;

			// Act
			var result = Solution.FindNumberOfElementsBetween(input, i1, j1, i2, j2);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
