using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem74Tests
{
	[TestFixture]
	public class GetXOccurencesCountTests
	{
		[TestCase(6, 12, 4)]
		[TestCase(2, 12, 0)]
		public void TestGetXOccurencesCount_ShouldReturnCorrectly(int n, int x, int expected)
		{
			// Arrange, Act
			var actual = Solutions.Problem74.Solution.GetXOccurencesCount(n, x);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
