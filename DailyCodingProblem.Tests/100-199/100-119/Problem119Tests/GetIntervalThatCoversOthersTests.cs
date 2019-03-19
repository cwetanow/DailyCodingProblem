using System.Collections.Generic;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem119Tests
{
	[TestFixture]
	public class GetIntervalThatCoversOthersTests
	{
		[Test]
		public void TestGetIntervalThatCoversOthers_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<(int start, int end)> { (0, 3), (2, 6), (3, 4), (6, 9) };

			var expectedStart = 3;
			var expectedEnd = 6;

			// Act
			var (start, end) = DailyCodingProblem.Solutions.Problem119.Solution.GetIntervalThatCoversOthers(input);

			// Assert
			Assert.AreEqual(expectedStart, start);
			Assert.AreEqual(expectedEnd, end);
		}
	}
}
