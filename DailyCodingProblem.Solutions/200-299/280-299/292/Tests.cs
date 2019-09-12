using System.Collections.Generic;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem292
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFindSatisfactoryPairOfTeams_HasSatisfactoryPair_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new List<IList<int>>
			{
				new List<int> { 3},
				new List<int> {2 },
				new List<int> { 1,4},
				new List<int> {0,4,5 },
				new List<int> { 2,3},
				new List<int> { 3}
			};

			var expectedResult = new List<IList<int>>
			{
				new List<int>{0,1,4,5},
				new List<int>{2,3}
			};

			// Act
			var actual = Solution.FindSatisfactoryPairOfTeams(input);

			// Assert
			CollectionAssert.AreEquivalent(expectedResult, actual);
		}


		[Test]
		public void TestFindSatisfactoryPairOfTeams_DoesNotHasSatisfactoryPair_ShouldReturnNull()
		{
			// Arrange
			var input = new List<IList<int>>
			{
				new List<int> { 3},
				new List<int> {2 },
				new List<int> { 1,3,4},
				new List<int> {0,2,4,5 },
				new List<int> { 2,3},
				new List<int> { 3}
			};

			// Act
			var actual = Solution.FindSatisfactoryPairOfTeams(input);

			// Assert
			Assert.IsNull(actual);
		}
	}
}
