using System;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem73
{
	public static class Solution
	{
		public static void Test()
		{
		}

		public static void Reverse<T>(this Common.LinkedList<T> list)
			where T : IComparable<T>, IEquatable<T>
		{
			var currentNode = list.Root;
			var previousNode = (Common.LinkedList<T>.LinkedListNode)null;

			while (currentNode != null)
			{
				var nextNode = currentNode.Next;

				currentNode.Next = previousNode;
				previousNode = currentNode;
				currentNode = nextNode;
			}

			list.Root = previousNode;
		}

		public static IList<T> ToList<T>(this Common.LinkedList<T> linkedList)
			where T : IComparable<T>, IEquatable<T>
		{
			var list = new List<T>();

			if (linkedList.Root != null)
			{
				var currentNode = linkedList.Root;

				while (currentNode != null)
				{
					list.Add(currentNode.Value);
					currentNode = currentNode.Next;
				}
			}

			return list;
		}
	}
}
