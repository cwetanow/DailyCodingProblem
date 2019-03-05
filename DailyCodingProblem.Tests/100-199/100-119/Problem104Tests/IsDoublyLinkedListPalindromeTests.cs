using System.Collections.Generic;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem104Tests
{
	[TestFixture]
	public class IsDoublyLinkedListPalindromeTests
	{
		[Test]
		public void TestIsDoublyLinkedListPalindrome_ListIsPalindrome_ShouldReturnTrue()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.AddLast(1);
			list.AddLast(4);
			list.AddLast(3);
			list.AddLast(4);
			list.AddLast(1);

			// Act
			var result = Solutions.Problem104.Solution.IsDoublyLinkedListPalindrome(list);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsDoublyLinkedListPalindrome_ListIsNotPalindrome_ShouldReturnFalse()
		{
			// Arrange
			var list = new LinkedList<int>();
			list.AddLast(1);
			list.AddLast(4);

			// Act
			var result = Solutions.Problem104.Solution.IsDoublyLinkedListPalindrome(list);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
