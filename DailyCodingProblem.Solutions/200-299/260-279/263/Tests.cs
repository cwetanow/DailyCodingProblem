using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem263
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestIsValidSentence_IsValid_ShouldReturnTrue()
		{
			// Arrange
			var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

			// Act
			var result = Solution.IsValidSentence(sentence);

			// Assert
			Assert.IsTrue(result);
		}

		[TestCase(1, "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")]
		[TestCase(1, "LOrem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")]
		[TestCase(1, "Lorem ipsum dolor sit amEt, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")]
		[TestCase(1, "Lorem ipsum dolor  sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")]
		[TestCase(1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua")]
		public void TestIsValidSentence_IsNotValid_ShouldReturnFalse(int randomNum, string invalidSentence)
		{
			// Arrange, Act
			var result = Solution.IsValidSentence(invalidSentence);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
