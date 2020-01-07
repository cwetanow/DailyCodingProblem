using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem372
{
	[TestFixture]
	public class Tests
	{
		[TestCase(12, 2)]
		[TestCase(5555, 4)]
		public void TestGetNumberOfDigits_ShouldReturnCorrectly(int number, int expectedResult)
		{
			// Arrange, Act
			var actual = Solution.GetNumberOfDigits(number);

			// Assert
			actual.Should().Be(expectedResult);
		}
	}
}
