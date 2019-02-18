using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem11
{
	public class Trie
	{
		private class Node
		{
			public Node()
			{
				this.Children = new Dictionary<char, Node>();
			}

			public Node(char value)
				: this()
			{
				this.Character = value;
			}

			public char? Character { get; set; }

			public string Text { get; set; }

			public IDictionary<char, Node> Children { get; set; }
		}

		private Node root = new Node();

		public void Add(string text)
		{
			var currentNode = this.root;

			for (int i = 0; i < text.Length; i++)
			{
				var current = text[i];

				if (!currentNode.Children.ContainsKey(current))
				{
					var newNode = new Node(current);

					currentNode.Children.Add(current, newNode);
				}

				currentNode = currentNode.Children[current];
			}

			currentNode.Text = text;
		}

		public IEnumerable<string> Search(string queryString)
		{
			var node = this.Find(queryString);

			var result = this.GetTexts(node);

			return result;
		}

		private IEnumerable<string> GetTexts(Node node)
		{
			var result = new List<string>();

			if (node == null)
			{
				return result;
			}

			if (!string.IsNullOrEmpty(node.Text))
			{
				result.Add(node.Text);
			}

			foreach (var kvp in node.Children)
			{
				result.AddRange(GetTexts(kvp.Value));
			}

			return result;
		}

		private Node Find(string queryString)
		{
			var currentNode = this.root;

			for (int i = 0; i < queryString.Length; i++)
			{
				var current = queryString[i];

				if (currentNode.Children.ContainsKey(current))
				{
					currentNode = currentNode.Children[current];
				}
				else
				{
					return null;
				}
			}

			return currentNode;
		}
	}

}
