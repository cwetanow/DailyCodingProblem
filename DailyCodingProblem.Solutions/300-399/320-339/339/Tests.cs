using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem339
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestAreThereThreeEntriesWhichAddUpToK_ShouldReturnTrue()
		{
			// Arrange
			var numbers = new[] { 20, 303, 3, 4, 25 };
			var k = 49;

			// Act
			var actualResult = Solution.AreThereThreeEntriesWhichAddUpToK(k, numbers);

			// Assert
			actualResult.Should().BeTrue();
		}
	}
}
