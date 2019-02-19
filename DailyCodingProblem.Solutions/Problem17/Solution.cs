using DailyCodingProblem.Solutions.Common;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem17
{
	public class Solution
	{
		public static (string longestPath, int length) GetLongestPath(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return (string.Empty, 0);
			}

			var root = ParseInput(input);

			return GetLongestPath(root, root.Value, root.Value.Length);
		}

		private static Node<string> ParseInput(string input)
		{

		}

		private static (string longestPath, int length) GetLongestPath(Node<string> node, string currentLongestPath, int currentLength)
		{
			if (!node.Children.Any())
			{
				return (currentLongestPath, currentLength);
			}

			var longestPath = string.Empty;
		}
	}
}
