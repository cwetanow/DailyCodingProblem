using NUnit.Framework;

namespace Tests.Problem69Tests
{
	[TestFixture]
	public class GetLargestProductTests
	{
		[Test]
		public void TestGetLargestProduct_ShouldReturnCorrectly()
		{
			// Arrange
			var numbers = new int[] { -10, -10, 5, 2 };

			var expectedResult = 500;

			// Act
			var result = Problem69.Program.GetLargestProduct(numbers);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
