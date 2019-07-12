using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem232
{
	public class Solution
	{
		private class TrieNode
		{
			public TrieNode(char character)
			{
				this.Character = character;
				this.Sum = Sum;
				this.Children = new Dictionary<char, TrieNode>();
			}

			public char Character { get; set; }

			public int Sum { get; set; }

			public IDictionary<char, TrieNode> Children { get; set; }
		}

		private readonly IDictionary<char, TrieNode> trieNodes = new Dictionary<char, TrieNode>();

		public void Insert(string key, int value)
		{
			var nodes = trieNodes;

			foreach (var character in key)
			{
				if (!nodes.ContainsKey(character))
				{
					nodes.Add(character, new TrieNode(character));
				}

				var node = nodes[character];
				node.Sum += value;

				nodes = node.Children;
			}
		}

		public int Sum(string prefix)
		{
			var nodes = trieNodes;
			var node = (TrieNode)null;

			foreach (var character in prefix)
			{
				if (nodes.ContainsKey(character))
				{
					node = nodes[character];
					nodes = nodes[character].Children;
				}
			}

			return node?.Sum ?? 0;
		}
	}
}
