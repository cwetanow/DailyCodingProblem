using System;

namespace Problem80
{
	public class Program
	{
		static void Main(string[] args)
		{
		}

		public static T GetDeepestNode<T>(Node<T> root)
		{
			var (value, level) = GetDeepestNode(root, 0);

			return value;
		}

		private static (T value, int level) GetDeepestNode<T>(Node<T> node, int currentLevel)
		{
			if (node.Left == null && node.Right == null)
			{
				return (node.Value, currentLevel);
			}

			var deepestValue = default(T);
			var deepestLevel = currentLevel;

			if (node.Left != null)
			{
				(deepestValue, deepestLevel) = GetDeepestNode<T>(node.Left, currentLevel + 1);
			}

			if (node.Right != null)
			{
				var (value, level) = GetDeepestNode<T>(node.Right, currentLevel + 1);

				if (level > deepestLevel)
				{
					deepestLevel = level;
					deepestValue = value;
				}
			}

			return (deepestValue, deepestLevel);
		}
	}
}
