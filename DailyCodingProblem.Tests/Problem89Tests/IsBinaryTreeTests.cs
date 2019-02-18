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
			var root = new Node<int>(5,
				new Node<int>(3,
					new Node<int>(2), new Node<int>(4)),
				new Node<int>(7,
					new Node<int>(6), new Node<int>(8)));

			// Act
			var result = Solutions.Problem89.Solution.IsBinaryTree(root);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsBinaryTree_InputIsNotBinaryTree_ShouldReturnFalse()
		{
			// Arrange
			var root = new Node<int>(1, new Node<int>(3), new Node<int>(5));

			// Act
			var result = Solutions.Problem89.Solution.IsBinaryTree(root);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
