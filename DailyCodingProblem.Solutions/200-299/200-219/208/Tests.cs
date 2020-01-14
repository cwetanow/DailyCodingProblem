using DailyCodingProblem.Solutions.Common;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem208
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestPartitionList_ShouldReturnCorrectly()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.Add(5);
			list.Add(1);
			list.Add(8);
			list.Add(0);
			list.Add(3);

			var k = 3;

			var expectedResult = new LinkedList<int>();
			expectedResult.Add(1);
			expectedResult.Add(0);
			expectedResult.Add(5);
			expectedResult.Add(8);
			expectedResult.Add(3);

			// Act
			var actualResult = Solution.PartitionList(list, k);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
