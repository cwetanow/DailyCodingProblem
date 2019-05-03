using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem153
{
	[TestFixture]
	public class Tests
	{
		[TestCase("dog cat hello cat dog dog hello cat world", "hello", "world", 1)]
		public void TestFindMajorityElement_ShouldReturnCorrectly(string text, string word, string otherWord, int expectedResult)
		{
			// Arrange, Act
			var result = Solution.FindSmallestDistanceBetweenWords(text, word, otherWord);

			// Assert
			Assert.AreEqual(expectedResult, result);
		}
	}
}
