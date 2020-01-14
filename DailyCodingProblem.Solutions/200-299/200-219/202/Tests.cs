using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem202
{
	[TestFixture]
	public class Tests
	{
		[TestCase(121)]
		[TestCase(888)]
		public void TestIsPalindrome_IsPalindrome_ShouldReturnTrue(int number)
		{
			// Arrange, Act
			var actualResult = Solution.IsPalindrome(number);

			// Assert
			actualResult.Should().BeTrue();
		}

		[TestCase(678)]
		public void TestIsPalindrome_IsNotPalindrome_ShouldReturnFalse(int number)
		{
			// Arrange, Act
			var actualResult = Solution.IsPalindrome(number);

			// Assert
			actualResult.Should().BeFalse();
		}
	}
}
