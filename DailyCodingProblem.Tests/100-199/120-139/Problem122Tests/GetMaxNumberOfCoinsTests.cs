using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem122Tests
{
	[TestFixture]
	public class GetMaxNumberOfCoinsTests
	{
		[Test]
		public void TestGetMaxNumberOfCoins_ShouldReturnCorrectly()
		{
			// Arrange
			var input = new int[3][]
			{
				new int[]{0,3,1,1},
				new int[]{2,0,0,4},
				new int[]{1,5,3,1},
			};

			var expectedResult = 12;

			// Act
			var result = Solutions.Problem122.Solution.GetMaxNumberOfCoins(input);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
