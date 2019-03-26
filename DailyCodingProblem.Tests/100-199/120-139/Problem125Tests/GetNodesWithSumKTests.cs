using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem125Tests
{
	[TestFixture]
	public class GetNodesWithSumKTests
	{
		[Test]
		public void TestGetNodesWithSumK_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Node<int>(10,
				new Node<int>(5),
				new Node<int>(15,
					new Node<int>(11),
					new Node<int>(15)));

			var k = 20;

			var expectedResult = new int[] { 5, 15 };

			// Act
			var result = Solutions.Problem125.Solution.GetNodesWithSumK(root, k);

			// Assert
			CollectionAssert.AreEquivalent(expectedResult, result);
		}
	}
}
