using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem241
{
	[TestFixture]
	public class Tests
	{
		[TestCase(3, new[] { 4, 3, 0, 1, 5 })]
		public void TestGetHIndex_ShouldReturnCorrectly(int expectedResult, int[] paperCitations)
		{
			// Arrange, Act
			var index = Solution.GetHIndex(paperCitations);

			// Assert
			Assert.AreEqual(expectedResult, index);
		}
	}
}
