using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblem.Tests.Problem126Tests
{
	[TestFixture]
	public class RotateListTests
	{
		[Test]
		public void TestRotateList_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<int> { 1, 2, 3, 4, 5, 6 };
			var k = 2;

			var expectedResult = new List<int> { 3, 4, 5, 6, 1, 2 };

			// Act
			var actual = Solutions.Problem126.Solution.RotateList(input, k);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actual);
		}
	}
}
