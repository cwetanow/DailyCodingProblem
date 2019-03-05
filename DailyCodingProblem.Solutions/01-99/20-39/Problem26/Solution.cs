using System;

namespace DailyCodingProblem.Solutions.Problem26
{
	public static class Solution
	{
		public static void Test()
		{
			var list = new ExtendedLinkedList<int>();

			for (int i = 1; i < 11; i++)
			{
				list.Add(i);
			}

			var k = int.Parse(Console.ReadLine());

			var number = list.RemoveKthLastElement(k);

			Console.WriteLine(number);
		}
	}
}
