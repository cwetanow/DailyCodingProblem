using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem113Tests
{
	[TestFixture]
	public class ReverseWordsTests
	{
		[Test]
		public void TestReverseWords_ShouldReturnCorrectly()
		{
			// Arrange
			var input = "hello world here";
			var expectedResult = "here world hello";

			// Act
			var actual = Solutions.Problem113.Solution.ReverseWords(input);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
