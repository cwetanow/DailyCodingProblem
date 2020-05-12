using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem349
{
	[TestFixture]
	public class Tests
	{
		[TestCase("Jackson", "J250")]
		[TestCase("Jaxen", "J250")]
		public void TestSoundex_ShouldReturnCorrectly(string input, string expected)
		{
			// Arrange, Act
			var actual = Solution.Soundex(input);

			// Assert
			actual.Should().BeEquivalentTo(expected);
		}
	}
}
