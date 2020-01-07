using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem363
{
	[TestFixture]
	public class Tests
	{
		[TestCase(7, 7)]
		[TestCase(1, 0, 2, 3)]
		[TestCase(-5, 11, 10, 3, 9)]
		public void Test_ShouldReturnCorrectly(int initialNumber, int expectedResult, params int[] otherNumbers)
		{
			// Arrange
			var builder = AddSubtractBuilder.Create(initialNumber);

			foreach (var otherNumber in otherNumbers)
			{
				builder.Append(otherNumber);
			}
			
			// Act
			var actualResut = builder.Compute();

			// Assert
			actualResut.Should().Be(expectedResult);
		}
	}
}
