using System;

namespace DailyCodingProblem.Solutions.Problem06
{
	public class Solution
	{
		public static void Test(string[] args)
		{
			var list = new InMemoryLinkedList<int>();

			for (var i = 0; i < 10; i++)
			{
				list.Add(i);
			}

			Console.WriteLine(list.Get(5));
		}
	}

}
