namespace DailyCodingProblem.Solutions.Problem315
{
	public class Solution
	{
		public static bool IsToeplitzMatrix(int[][] matrix, int rows, int cols)
		{
			var row = 0;
			var col = cols - 1;

			while (row != rows - 1 && col != 0)
			{
				var currentRow = row + 1;
				var currentCol = col + 1;

				var number = matrix[row][col];

				while (currentRow < rows && currentCol < cols)
				{
					if (matrix[currentRow][currentCol] != number)
					{
						return false;
					}

					currentRow++;
					currentCol++;
				}

				if (col > 0)
				{
					col--;
				}
				else
				{
					row++;
				}
			}

			return true;
		}
	}
}
