using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem315
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestIsToeplitzMatrix_SatisfiesCondition_ShouldReturnTrue()
		{
			// Arrange
			var matrix = new[]
			{
				new []{ 1, 2, 3, 4, 8 },
				new []{ 5, 1, 2, 3, 4 },
				new []{ 4, 5, 1, 2, 3 },
				new []{ 7, 4, 5, 1, 2 },
			};

			// Act
			var actualResult = Solution.IsToeplitzMatrix(matrix, 4, 5);

			// Assert
			actualResult.Should().BeTrue();
		}

		[Test]
		public void TestIsToeplitzMatrix_DoesnotSatisfyCondition_ShouldReturnTrue()
		{
			// Arrange
			var matrix = new[]
			{
				new []{ 1, 2, 3, 4, 5 },
				new []{ 5, 1, 2, 3, 5 },
				new []{ 4, 5, 1, 2, 3 },
				new []{ 7, 4, 5, 1, 2 },
			};

			// Act
			var actualResult = Solution.IsToeplitzMatrix(matrix, 4, 5);

			// Assert
			actualResult.Should().BeFalse();
		}
	}
}
