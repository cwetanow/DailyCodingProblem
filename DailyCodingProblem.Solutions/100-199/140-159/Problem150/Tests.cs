using System.Collections.Generic;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem150
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindNearestKPoints_ShouldReturnCorrectly()
		{
			// Arrange
			var points = new List<(int x, int y)>
			{
				(0, 0), (5, 4), (3, 1)
			};

			var center = (1, 2);
			var k = 2;

			var expectedResult = new List<(int x, int y)>
			{
				(0,0),(3,1)
			};

			// Act
			var result = Solution.FindNearestKPoints(points, center, k);

			// Assert
			CollectionAssert.AreEqual(expectedResult, result);
		}
	}
}
