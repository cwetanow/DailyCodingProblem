using System.Collections.Generic;
using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem110Tests
{
	[TestFixture]
	public class GetPathsToLeavesTests
	{
		[Test]
		public void TestGetPathsToLeaves_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Node<int>(1,
				new Node<int>(2),
				new Node<int>(3,
					new Node<int>(4),
					new Node<int>(5)));

			var expected = new List<List<int>>()
			{
				new List<int> { 1, 2 },
				new List<int> { 1, 3,4 },
				new List<int> { 1, 3,5 }
			};

			// Act
			var actual = Solutions.Problem110.Solution.GetPathsToLeaves(root);

			// Assert
			CollectionAssert.AreEquivalent(expected, actual);
		}
	}
}
