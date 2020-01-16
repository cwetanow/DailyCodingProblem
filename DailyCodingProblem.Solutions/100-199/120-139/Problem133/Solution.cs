using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem133
{
	public class Solution
	{
		public static Node<int> GetInorderSuccessor(Node<int> node) => node.Right ?? node.Parent;
	}
}
