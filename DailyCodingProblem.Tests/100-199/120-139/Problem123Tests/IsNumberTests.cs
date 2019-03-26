using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem123Tests
{
	[TestFixture]
	public class IsNumberTests
	{
		[TestCase("10")]
		[TestCase("-10")]
		[TestCase("10.1")]
		[TestCase("-10.1")]
		[TestCase("1e5")]
		public void TestIsNumber_IsNumber_ShouldReturnTrue(string input)
		{
			// Arrange, Act
			var result = Solutions.Problem123.Solution.IsNumber(input);

			// Assert
			Assert.IsTrue(result);
		}

		[TestCase("a")]
		[TestCase("x 1")]
		[TestCase("a -2")]
		[TestCase("-")]
		public void TestIsNumber_IsNotNumber_ShouldReturnFalse(string input)
		{
			// Arrange, Act
			var result = Solutions.Problem123.Solution.IsNumber(input);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
