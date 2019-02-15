using System.Linq;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem01Tests
{
	[TestFixture]
	public class TwoNumbersEqualTests
	{
		[Test]
		public void TestProblem01Solution_NumbersAddUpToK_ShouldReturnTrue()
		{
			// Arrange
			var numbers = new[] { 10, 15, 3, 7 }
				.ToList();
			var k = 17;

			// Act
			var result = Solutions.Problem01.Solution.TwoNumbersEqual(numbers, k);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestProblem01Solution_NumbersDoNotAddUpToK_ShouldReturnFalse()
		{
			// Arrange
			var numbers = new[] { 10, 15, 3, 7 }
				.ToList();
			var k = 16;

			// Act
			var result = Solutions.Problem01.Solution.TwoNumbersEqual(numbers, k);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
