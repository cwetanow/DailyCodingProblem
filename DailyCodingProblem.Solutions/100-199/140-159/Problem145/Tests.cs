using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem145
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestSwapEveryTwoNodes_ShouldReturnCorrectly()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);

			var expectedList = new LinkedList<int>();
			expectedList.Add(2);
			expectedList.Add(1);
			expectedList.Add(4);
			expectedList.Add(3);

			// Act
			var result = Solution.SwapEveryTwoNodes(list);

			// Assert
			Assert.AreEqual(expectedList, result);
		}
	}
}
