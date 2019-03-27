using System;

namespace DailyCodingProblem.Solutions.Problem26
{
	public class ExtendedLinkedList<T> : Common.LinkedList<T>
	where T : IComparable<T>, IEquatable<T>
	{
		public T RemoveKthLastElement(int k)
		{
			var iterations = this.count - k;

			var currentNode = this.Root;
			var previousNode = (LinkedListNode)null;

			while (iterations > 0)
			{
				previousNode = currentNode;
				currentNode = currentNode.Next;
				iterations--;
			}

			previousNode.Next = currentNode.Next;
			this.count--;

			return currentNode.Value;
		}
	}
}
