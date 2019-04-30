using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem159
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindFirstRecurringCharacter_ThereIsRecurringCharacter_ShouldReturnCorrectly()
		{
			// Arrange
			var input = "acbbac";
			var expectedResult = 'b';

			// Act
			var result = Solution.FindFirstRecurringCharacter(input);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}

		[Test]
		public void TestFindFirstRecurringCharacter_ThereIsNoRecurringCharacter_ShouldReturnNull()
		{
			// Arrange
			var input = "abcdef";

			// Act
			var result = Solution.FindFirstRecurringCharacter(input);

			// Assert
			Assert.IsNull(result);
		}
	}
}
