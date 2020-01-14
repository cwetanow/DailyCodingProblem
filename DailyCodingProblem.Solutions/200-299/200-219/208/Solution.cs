using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem208
{
	public class Solution
	{
		public static LinkedList<int> PartitionList(LinkedList<int> list, int k)
		{
			var root = (LinkedList<int>.LinkedListNode)null;
			var left = (LinkedList<int>.LinkedListNode)null;

			var rightRoot = (LinkedList<int>.LinkedListNode)null;
			var right = (LinkedList<int>.LinkedListNode)null;

			var current = list.Root;
			while (current != null)
			{
				if (current.Value < k)
				{
					if (root == null)
					{
						root = new LinkedList<int>.LinkedListNode(current.Value);
						left = root;
					}
					else
					{
						left = new LinkedList<int>.LinkedListNode(current.Value, left);
					}
				}
				else
				{
					if (rightRoot == null)
					{
						rightRoot = new LinkedList<int>.LinkedListNode(current.Value);
						right = rightRoot;
					}
					else
					{
						right = new LinkedList<int>.LinkedListNode(current.Value, right);
					}
				}

				current = current.Next;
			}

			if (left != null)
			{
				if (right != null)
				{
					left.Next = rightRoot;
				}
			}
			else if (right != null)
			{
				root = rightRoot;
			}

			return new LinkedList<int> { Root = root };
		}
	}
}
