using System;

namespace DailyCodingProblem.Solutions.Problem11
{
	public class Solution
	{
		public static void Test()
		{
			var trie = new Trie();

			trie.Add("dog");
			trie.Add("deer");
			trie.Add("deal");

			var results = trie.Search("de");

			foreach (var item in results)
			{
				Console.WriteLine(item);
			}
		}
	}
}
