using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem268
{
	[TestFixture]
	public class Tests
	{
		[TestCase(16, 4)]
		[TestCase(64, 4)]
		[TestCase(256, 4)]
		public void TestIsPowerOf_NumberIsPower_ShouldReturnTrue(int number, int poweredNumber)
		{
			// Arrange, Act
			var result = Solution.IsPowerOf(number, poweredNumber);

			// Assert
			Assert.IsTrue(result);
		}

		[TestCase(32, 4)]
		[TestCase(128, 4)]
		[TestCase(11, 4)]
		public void TestIsPowerOf_NumberIsNotPower_ShouldReturnFalse(int number, int poweredNumber)
		{
			// Arrange, Act
			var result = Solution.IsPowerOf(number, poweredNumber);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
