using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem237
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestIsTreeSymmetric_ShouldReturnCorrectly()
		{
			// Arrange
			var k = 3;

			var root = new Solution.TreeNode(4,
				new Solution.TreeNode(3, new Solution.TreeNode(9)),
				new Solution.TreeNode(5),
				new Solution.TreeNode(3, new Solution.TreeNode(9))
				);

			// Act
			var result = Solution.IsTreeSymmetric(root, k);

			// Assert
			result.Should().BeTrue();
		}
	}
}
