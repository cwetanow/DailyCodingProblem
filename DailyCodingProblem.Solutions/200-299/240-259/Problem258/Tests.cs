using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem258
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestGetBoustrophedonText_ShouldReturnCorrectly()
		{
			// Arrange
			var root = new Node<int>(1,
				new Node<int>(2,
					new Node<int>(4),
					new Node<int>(5)),
				new Node<int>(3,
					new Node<int>(6),
					new Node<int>(7)));

			var expectedResult = new int[] { 1, 3, 2, 4, 5, 6, 7 };

			// Act
			var actual = Solution.GetBoustrophedonText(root);

			// Assert
			CollectionAssert.AreEqual(expectedResult, actual);
		}
	}
}
