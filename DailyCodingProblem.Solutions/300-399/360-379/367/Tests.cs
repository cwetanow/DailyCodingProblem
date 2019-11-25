using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem367
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestMergeIterators_ShouldReturnCorrectly()
		{
			// Arrange
			var firstList = new List<int> { 5, 10, 15 };
			var secondList = new List<int> { 3, 8, 9 };
			var expectedResult = new List<int> { 3, 5, 8, 9, 10, 15 };

			using (var firstIterator = firstList.GetEnumerator())
			using (var secondIterator = secondList.GetEnumerator())
			{
				// Act
				var actualResult = Solution.MergeIterators(firstIterator, secondIterator).ToList();

				// Assert

				actualResult.Should().BeEquivalentTo(expectedResult);
			}
		}
	}
}
