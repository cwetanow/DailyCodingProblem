using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem106Tests
{
	[TestFixture]
	public class CanReachLastIndexTests
	{
		[Test]
		public void TestCanReachLastIndex_CanReach_ShouldReturnTrue()
		{
			// Arrange
			var list = new[] { 2, 0, 1, 0 };

			// Act
			var result = Solutions.Problem106.Solution.CanReachLastIndex(list);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestCanReachLastIndex_CanNotReach_ShouldReturnFalse()
		{
			// Arrange
			var list = new[] { 1, 1, 0, 1 };

			// Act
			var result = Solutions.Problem106.Solution.CanReachLastIndex(list);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
