using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem342
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestReduce_ShouldReturnCorrectly()
		{
			// Arrange
			var input = Enumerable.Range(1, 10).ToList();
			var expectedResult = input.Sum();

			var sumFunc = new Func<int, int, int>((a, b) => a + b);

			// Act
			var actualResult = Solution.Reduce(input, sumFunc, 0);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
