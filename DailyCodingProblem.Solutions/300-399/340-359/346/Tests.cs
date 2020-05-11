using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem346
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetCheapestItinerary_ShouldReturnCorrectly()
		{
			// Arrange
			var fligths = new List<(string source, string destination, int price)>
			{
				("JFK", "ATL", 150),
				("ATL", "SFO", 400),
				("ORD", "LAX", 200),
				("LAX", "DFW", 80),
				("JFK", "HKG", 800),
				("ATL", "ORD", 90),
				("JFK", "LAX", 500)
			};

			var source = "JFK";
			var destination = "LAX";
			var maxConnections = 3;

			var expected = "JFK -> ATL -> ORD -> LAX";

			// Act
			var result = Solution.GetCheapestItinerary(source, destination, maxConnections, fligths);

			// Assert
			result.Should().Be(expected);
		}
	}
}
