using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblem.Tests.Problem77Tests
{
	[TestFixture]
	public class MergeOverlappingIntervalsTests
	{
		[Test]
		public void TestMergeOverlappingIntervals_ShouldReturnCorrectResult()
		{
			// Arrange
			var input = new List<(int start, int end)> {
		(1, 3), (5, 8), (4, 10), (20, 25)
	  };

			var expectedResult = new List<(int start, int end)> {
		(1, 3), (4, 10), (20, 25)
	  };

			// Act
			var actual = Solutions.Problem77.Solution.MergeOverlappingIntervals(input);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actual);
		}
	}
}
