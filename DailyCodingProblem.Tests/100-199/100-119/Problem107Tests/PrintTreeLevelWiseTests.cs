using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem107Tests
{
	[TestFixture]
	public class PrintTreeLevelWiseTests
	{
		[Test]
		public void TestPrintTreeLevelWise_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Solutions.Common.Node<int>(1,
				new Node<int>(2),
				new Node<int>(3,
					new Node<int>(4),
					new Node<int>(5)));

			var expectedResult = "1 2 3 4 5";

			// Act
			var actual = Solutions.Problem107.Solution.PrintTreeLevelWise(root);

			// Assert
			Assert.AreEqual(expectedResult, actual);
		}
	}
}
