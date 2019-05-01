using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem155
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindMajorityElement_ShouldReturnCorrectly()
		{
			// Arrange
			var numbers = new int[] { 1, 2, 1, 1, 3, 4, 0 };
			var expectedResult = 1;

			// Act
			var actual = Solution.FindMajorityElement(numbers);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
