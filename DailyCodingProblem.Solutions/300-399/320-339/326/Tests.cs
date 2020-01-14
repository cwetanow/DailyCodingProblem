using DailyCodingProblem.Solutions.Common;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem326
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestBuildCartesianTree_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new[] { 3, 2, 6, 1, 9 };

			var expectedResult = new Node<int>(
				1,
				new Node<int>(2,
					new Node<int>(3),
					new Node<int>(6)),
				new Node<int>(9)
			);

			// Act
			var actualResult = Solution.BuildCartesianTree(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult, 
				opts => opts.Excluding(c => c.Parent).IgnoringCyclicReferences());
		}
	}
}
