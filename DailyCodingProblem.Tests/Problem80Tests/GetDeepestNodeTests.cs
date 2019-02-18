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
			var root = new Node<string>("a",
			  new Node<string>("b",
				new Node<string>("d"), null),
			  new Node<string>("c"));

			var expected = "d";

			// Act
			var deepestNode = Solutions.Problem80.Solution.GetDeepestNode(root);

			// Assert
			Assert.AreEqual(expected, deepestNode);
		}
	}
}
