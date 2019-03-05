using DailyCodingProblem.Solutions.Common;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem104Tests
{
	[TestFixture]
	public class IsSinglyLinkedListPalindromeTests
	{
		[Test]
		public void TestIsSinglyLinkedListPalindrome_ListIsPalindrome_ShouldReturnTrue()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.Add(1);
			list.Add(4);
			list.Add(3);
			list.Add(4);
			list.Add(1);

			// Act
			var result = Solutions.Problem104.Solution.IsSinglyLinkedListPalindrome(list);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsSinglyLinkedListPalindrome_ListIsNotPalindrome_ShouldReturnFalse()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.Add(1);
			list.Add(4);

			// Act
			var result = Solutions.Problem104.Solution.IsSinglyLinkedListPalindrome(list);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
