using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem371
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetVariablesWithValues_ShouldReturnCorrectly()
		{
			// Arrange
			var equations = new List<string>
			{
				"y = x + 1",
				"5 = x + 3",
				"10 = z + y + 2"
			};

			var expected = new Dictionary<string, int>
			{
				{"x",2 },
				{"y",3 },
				{"z",5 }
			};

			// Act
			var actual = Solution.GetVariablesWithValues(equations);

			// Assert
			actual.Should().BeEquivalentTo(expected);
		}


		[Test]
		public void TestGetVariablesWithValues_Impossible_ShouldReturnNull()
		{
			// Arrange
			var equations = new List<string>
			{
				"10 = z + y + 2"
			};

			// Act
			var actual = Solution.GetVariablesWithValues(equations);

			// Assert
			actual.Should().BeNull();
		}
	}
}
