using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem89Tests
{
	[TestFixture]
	public class IsBinaryTreeTests
	{
		[Test]
		public void TestIsBinaryTree_InputIsBinaryTree_ShouldReturnTrue()
		{
			// Arrange
			var root = new BinaryNode<int>(5,
				new BinaryNode<int>(3,
					new BinaryNode<int>(2), new BinaryNode<int>(4)),
				new BinaryNode<int>(7,
					new BinaryNode<int>(6), new BinaryNode<int>(8)));

			// Act
			var result = Solutions.Problem89.Solution.IsBinaryTree(root);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsBinaryTree_InputIsNotBinaryTree_ShouldReturnFalse()
		{
			// Arrange
			var root = new BinaryNode<int>(1, new BinaryNode<int>(3), new BinaryNode<int>(5));

			// Act
			var result = Solutions.Problem89.Solution.IsBinaryTree(root);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
