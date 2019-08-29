using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem282
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestContainsPythagoreanTriplet_Contains_ShouldReturnTrue()
		{
			// Arrange
			var input = new[] { 3, 4, 5, 12, 255 };

			// Act
			var result = Solution.ContainsPythagoreanTriplet(input);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestContainsPythagoreanTriplet_DoesNotContain_ShouldReturnFalse()
		{
			// Arrange
			var input = new[] { 3, 12, 255 };

			// Act
			var result = Solution.ContainsPythagoreanTriplet(input);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
