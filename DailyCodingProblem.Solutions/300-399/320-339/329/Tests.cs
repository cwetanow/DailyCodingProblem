using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem329
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestPairPeople_ShouldReturnCorrectly()
		{
			// Arrange
			var n = 3;
			var guyPreferences = new List<(string guy, ICollection<string> preferences)>
			{
				("andrew", new List<string> {"caroline", "abigail", "betty" }),
				("bill", new List<string> {"caroline", "betty", "abigail" }),
				("chester", new List<string> {"betty", "caroline", "abigail" })
			};

			var girlPreferences = new List<(string girl, ICollection<string> preferences)>
			{
				("abigail", new List<string> {"andrew", "bill", "chester" }),
				("betty", new List<string> { "bill", "andrew", "chester"}),
				("caroline", new List<string> {"bill", "chester", "andrew" })
			};

			var expectedResult = new List<(string guy, string girl)> {
				("andrew","abigail"),
				("bill","caroline"),
				("chester","betty")
			};

			// Act
			var actualResult = Solution.PairPeople(n, guyPreferences, girlPreferences);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
