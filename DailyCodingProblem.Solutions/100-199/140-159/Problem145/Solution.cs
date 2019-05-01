using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem145
{
	public class Solution
	{
		public static Common.LinkedList<int> SwapEveryTwoNodes(Common.LinkedList<int> list)
		{
			var current = list.Root;

			while (current != null)
			{
				SwapValues(current, current.Next);

				current = current.Next.Next;
			}

			return list;
		}

		private static void SwapValues(Common.LinkedList<int>.LinkedListNode node, Common.LinkedList<int>.LinkedListNode otherNode)
		{
			var swap = node.Value;
			node.Value = otherNode.Value;
			otherNode.Value = swap;
		}
	}
}
