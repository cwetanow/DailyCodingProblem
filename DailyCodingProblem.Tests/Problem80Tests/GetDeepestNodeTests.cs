using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem80Tests
{
	[TestFixture]
	public class GetDeepestNodeTests
	{
		[Test]
		public void TestGetDeepestNode_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new BinaryNode<string>("a",
			  new BinaryNode<string>("b",
				new BinaryNode<string>("d"), null),
			  new BinaryNode<string>("c"));

			var expected = "d";

			// Act
			var deepestNode = Solutions.Problem80.Solution.GetDeepestNode(root);

			// Assert
			Assert.AreEqual(expected, deepestNode);
		}
	}
}
