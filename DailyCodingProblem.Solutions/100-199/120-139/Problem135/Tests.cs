using DailyCodingProblem.Solutions.Common;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem135
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetMinimumPathSumToLeaf_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Node<int>(10,
				new Node<int>(5,
					right: new Node<int>(2)
					),
				new Node<int>(5,
					right: new Node<int>(1,
						left: new Node<int>(-1)
						)));

			var expectedResult = 15;

			// Act
			var actualResult = Solution.GetMinimumPathSumToLeaf(root);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
