using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem233
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestFibonacci_ShouldReturnCorrectly()
		{
			// Arrange
			var expectedResult = 89;
			var n = 10;

			// Act
			var result = Solution.Fibonacci(n);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
