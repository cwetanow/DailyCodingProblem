using System;
using DailyCodingProblem.Solutions.Problem26;

namespace DailyCodingProblem.Tests.Problem26Tests.Mock
{
	public class ExtendedWithContainsLinkedList<T>
	  : ExtendedLinkedList<T>
	  where T : IComparable<T>, IEquatable<T>
	{
		public bool Contains(T element)
		{
			if (this.Root == null)
			{
				return false;
			}

			var currentNode = this.Root;

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
