using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem78
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var k = int.Parse(Console.ReadLine());

			var itemsPerList = 3;

			var lists = CreateTestLists(k, itemsPerList);

			var mergedList = MergeLists(lists);

			var currentNode = mergedList.Root;

			while (currentNode != null)
			{
				Console.WriteLine(currentNode.Value);
				currentNode = currentNode.Next;
			}
		}

		public static Problem78.LinkedList<int> MergeLists(List<Problem78.LinkedList<int>> lists)
		{
			var list = new Problem78.LinkedList<int>();

			while (lists.Count > 0)
			{
				var min = lists.Min();

				list.Add(min.Root.Value);

				if (min.Root.Next == null)
				{
					lists.Remove(min);
				}
				else
				{
					min.Root = min.Root.Next;
				}
			}

			return list;
		}

		private static List<Problem78.LinkedList<int>> CreateTestLists(int k, int itemsPerList)
		{
			var lists = new List<Problem78.LinkedList<int>>(k);

			for (int i = 0; i < k; i++)
			{
				lists.Add(new Problem78.LinkedList<int>());
			}

			var itemsCount = k * itemsPerList;

			var random = new Random();

			for (int i = 0; i < itemsCount; i++)
			{
				var listIndex = random.Next(0, k);

				lists[listIndex].Add(i);
			}

			return lists;
		}
	}
}
