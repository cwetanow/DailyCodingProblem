namespace DailyCodingProblem.Solutions.Problem195
{
	public class Solution
	{
		public static int FindNumberOfElementsBetween(int[][] matrix, int i1, int j1, int i2, int j2)
		{
			var itemsCount = 0;

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if(matrix[i][j] < matrix[i1][j1] || matrix[i][j] > matrix[i2][j2])
					{
						itemsCount++;
					}
				}
			}

			return itemsCount;
		}
	}
}
