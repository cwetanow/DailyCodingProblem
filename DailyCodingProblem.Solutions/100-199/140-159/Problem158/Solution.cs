using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem158
{
	public class Solution
	{
		public static int GetWaysToReachBottomRight(int[][] matrix, int rows, int cols)
		{
			var ways = Enumerable.Range(0, rows)
				.Select(_ => Enumerable.Range(0, cols).Select(__ => 0).ToList())
				.ToList();

			Traverse(matrix, rows, cols, 0, 0, ways);

			return ways[rows - 1][cols - 1];
		}

		private static void Traverse(int[][] matrix, int rows, int cols, int currentRow, int currentCol, List<List<int>> ways)
		{
			if (currentRow == rows || currentCol == cols)
			{
				return;
			}

			if (matrix[currentRow][currentCol] == 1)
			{
				return;
			}

			ways[currentRow][currentCol]++;

			Traverse(matrix, rows, cols, currentRow + 1, currentCol, ways);
			Traverse(matrix, rows, cols, currentRow, currentCol + 1, ways);
		}
	}
}
