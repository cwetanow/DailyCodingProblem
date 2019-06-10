namespace DailyCodingProblem.Solutions.Problem195
{
	public class Solution
	{
		public static int FindNumberOfElementsBetween(int[][] matrix, int i1, int j1, int i2, int j2)
		{
			var itemsCount = 0;

			for (int i = 0; i < matrix.Length; i++)
			{
				var col = 0;

				while (matrix[i][col] < matrix[i1][j1])
				{
					itemsCount++;
					col++;
				}

				col = matrix[i].Length - 1;

				while (matrix[i][col] > matrix[i2][j2])
				{
					itemsCount++;
					col--;
				}
			}

			return itemsCount;
		}
	}
}
