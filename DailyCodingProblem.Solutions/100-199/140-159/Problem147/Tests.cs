using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem147
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestSortListWithReverse_ShouldReturnCorrectly()
		{
			// Arrange
			var list = Enumerable.Range(0, 10).ToList();

			var expectedResult = new List<int>(list);
			list.Reverse();

			// Act
			list.SortListWithReverse();

			// Assert
			list.Should().BeEquivalentTo(expectedResult).And.BeInAscendingOrder();
		}
	}
}
