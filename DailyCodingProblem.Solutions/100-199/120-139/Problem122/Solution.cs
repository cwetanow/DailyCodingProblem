namespace DailyCodingProblem.Solutions.Problem122
{
	public class Solution
	{
		private static int MaxNumberOfCoins = 0;

		private static int Rows;
		private static int Cols;

		public static int GetMaxNumberOfCoins(int[][] matrix)
		{
			Rows = matrix.Length;
			Cols = matrix[0].Length;

			GetMaxNumberOfCoins(matrix, 0, 0, 0);

			return MaxNumberOfCoins;
		}

		private static void GetMaxNumberOfCoins(int[][] matrix, int row, int col, int current)
		{
			current = current + matrix[row][col];

			if (row == Rows - 1 && col == Cols - 1)
			{
				if (MaxNumberOfCoins < current)
				{
					MaxNumberOfCoins = current;
				}

				return;
			}

			if (row < Rows - 1)
			{
				GetMaxNumberOfCoins(matrix, row + 1, col, current);
			}

			if (col < Cols - 1)
			{
				GetMaxNumberOfCoins(matrix, row, col + 1, current);
			}
		}
	}
}
