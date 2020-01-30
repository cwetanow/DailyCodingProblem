using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem274
{
	[TestFixture]
	public class Tests
	{
		[TestCase("-1 + (2 + 3)", 4)]
		[TestCase("(-1 + (2 + 3)) + 5 - (3 + 7)", -1)]
		public void TestEval_ShouldReturnCorrectly(string input, int expectedResult)
		{
			// Arrange, Act
			var actualResult = Solution.Eval(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
