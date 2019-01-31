using Problem26;
using System;

namespace Tests.Problem26Tests.Mock
{
	public class ExtendedLinkedList<T>
		: LinkedList<T>
		where T : IComparable<T>
	{
		public bool Contains(T element)
		{
			if (this.root == null)
			{
				return false;
			}

			var currentNode = this.root;

			while (currentNode != null)
			{
				if (currentNode.Value.CompareTo(element) == 0)
				{
					return true;
				}

				currentNode = currentNode.Next;
			}

			return false;
		}
	}
}
