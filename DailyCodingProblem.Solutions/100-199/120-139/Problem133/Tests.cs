using DailyCodingProblem.Solutions.Common;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem133
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetInorderSuccessor_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Node<int>(10);
			root.Left = new Node<int>(5, parent: root);
			root.Right = new Node<int>(30, parent: root);

			root.Right.Left = new Node<int>(22, parent: root.Right);
			root.Right.Right = new Node<int>(35, parent: root.Right);

			var inputNode = root.Right.Left;

			var expectedResult = root.Right;

			// Act
			var actualResult = Solution.GetInorderSuccessor(inputNode);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
