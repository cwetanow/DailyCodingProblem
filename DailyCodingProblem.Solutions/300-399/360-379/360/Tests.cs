using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem360
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetPlaylist_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<List<int>>
			{
				new List<int> {1, 7, 3 },
				new List<int> { 2, 1, 6, 7, 9},
				new List<int> { 3, 9, 5},
			};

			var expectedResult = new List<int>{ 2, 1, 6, 7, 3, 9, 5 };

			// Act
			var actualResult = Solution.GetPlaylist(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
