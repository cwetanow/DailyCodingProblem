using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem161Tests
{
	[TestFixture]
	public class GetReversedBitRepresentationTests
	{
		[Test]
		public void TestGetReversedBitRepresentation_ShouldReturnCorrectly()
		{
			// Arrange
			var number = 4042322160;// 1111 0000 1111 0000 1111 0000 1111 0000;

			var expectedResult = "00001111000011110000111100001111";

			// Act
			var result = Solutions.Problem161.Solution.GetReversedBitRepresentation(number);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
