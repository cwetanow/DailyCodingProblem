using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem40Tests
{
	[TestFixture]
	public class GetNonDuplicatedIntegerTests
	{
		[TestCase(1, new int[] { 6, 1, 3, 3, 3, 6, 6 })]
		[TestCase(19, new int[] { 13, 19, 13, 13 })]
		public static void TestGetNonDuplicatedInteger_ShouldReturnCorrectly(int expected, int[] input)
		{
			// Arrange, Act
			var actual = Solutions.Problem40.Solution.GetNonDuplicatedInteger(input);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
