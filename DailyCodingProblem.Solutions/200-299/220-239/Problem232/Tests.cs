using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem232
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestSum_ShouldReturnCorrectly()
		{
			// Arrange
			var mapsum = new Solution();
			mapsum.Insert("columnar", 3);
			mapsum.Insert("column", 2);

			var expectedResult = 5;

			// Act
			var sum = mapsum.Sum("col");

			// Assert
			Assert.AreEqual(expectedResult, sum);
		}
	}
}
