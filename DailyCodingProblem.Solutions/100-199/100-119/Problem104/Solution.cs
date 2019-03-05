using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem104
{
	public class Solution
	{
		public static bool IsDoublyLinkedListPalindrome(LinkedList<int> list)
		{
			var half = list.Count / 2;

			var left = list.First;
			var right = list.Last;

			for (int i = 0; i < half; i++)
			{
				if (left.Value != right.Value)
				{
					return false;
				}

				left = left.Next;
				right = right.Previous;
			}

			return true;
		}

		public static bool IsSinglyLinkedListPalindrome(Common.LinkedList<int> list)
		{
			var doublyLinkedList = new LinkedList<int>();

			var current = list.Root;

			while (current != null)
			{
				doublyLinkedList.AddLast(current.Value);

				current = current.Next;
			}

			return IsDoublyLinkedListPalindrome(doublyLinkedList);
		}
	}
}
