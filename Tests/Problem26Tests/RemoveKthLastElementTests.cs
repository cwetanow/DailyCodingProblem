using NUnit.Framework;
using Tests.Problem26Tests.Mock;

namespace Tests.Problem26Tests
{
	[TestFixture]
	public class RemoveKthLastElementTests
	{
		[Test]
		public void TestRemoveKthLastElement_ShouldReturnCorrectly()
		{
			// Arrange
			var list = new ExtendedLinkedList<int>();

			list.Add(4);
			list.Add(3);
			list.Add(2);
			list.Add(1);

			var k = 2;
			var expected = 2;

			// Act
			var actual = list.RemoveKthLastElement(k);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TestRemoveKthLastElement_ShouldRemoveElement()
		{
			// Arrange
			var list = new ExtendedLinkedList<int>();

			list.Add(4);
			list.Add(3);
			list.Add(2);
			list.Add(1);

			var k = 2;
			var element = 2;

			// Act
			list.RemoveKthLastElement(k);

			// Assert
			Assert.IsFalse(list.Contains(element));
		}
	}
}
