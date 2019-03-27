using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem127Tests
{
	[TestFixture]
	public class SumNumbersTests
	{
		[Test]
		public void TestSumNumbers_ShouldReturnCorrectly()
		{
			// Arrange
			var left = new LinkedList<int>();
			left.Add(9);
			left.Add(9);

			var right = new LinkedList<int>();
			right.Add(5);
			right.Add(2);

			var expectedResult = new LinkedList<int>();
			expectedResult.Add(4);
			expectedResult.Add(2);
			expectedResult.Add(1);
					   
			// Act
			var actual = Solutions.Problem127.Solution.SumNumbers(left, right);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
