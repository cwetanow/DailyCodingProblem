using System;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem267
{
	public class Solution
	{
		private static IDictionary<char, Func<char[][], int, int, (int, int), bool>> CheckFunctions = new Dictionary<char, Func<char[][], int, int, (int, int), bool>>();

		private const char King = 'K';
		private const char Queen = 'Q';
		private const char Bishop = 'B';
		private const char Pawn = 'P';
		private const char Rook = 'R';
		private const char Night = 'N';
		private const char Empty = '.';

		private const int BoardSize = 8;

		static Solution()
		{
			CheckFunctions.Add(Queen, CheckQueen);
			CheckFunctions.Add(Bishop, CheckBishop);
			CheckFunctions.Add(Pawn, CheckPawn);
			CheckFunctions.Add(Rook, CheckRook);
			CheckFunctions.Add(Night, CheckNight);
		}

		public static bool IsKingInCheck(char[][] board)
		{
			var kingPosition = FindKingPosition(board);

			for (var row = 0; row < BoardSize; row++)
			{
				for (var col = 0; col < BoardSize; col++)
				{
					if (board[row][col] != Empty && board[row][col] != King)
					{
						var checkFunction = CheckFunctions[board[row][col]];

						if (checkFunction(board, row, col, kingPosition))
						{
							return true;
						}
					}
				}
			}

			return false;
		}

		private static bool CheckQueen(char[][] board, int row, int col, (int row, int col) kingPosition)
		{
			return CheckBishop(board, row, col, kingPosition) || CheckRook(board, row, col, kingPosition);
		}

		private static bool CheckBishop(char[][] board, int row, int col, (int row, int col) kingPosition)
		{
			for (var i = -BoardSize; i < BoardSize; i++)
			{
				if (row + i == kingPosition.row && col + i == kingPosition.col)
				{
					return true;
				}
			}


			for (var i = -BoardSize; i < BoardSize; i++)
			{
				if (row - i == kingPosition.row && col + i == kingPosition.col)
				{
					return true;
				}
			}

			return false;
		}

		private static bool CheckRook(char[][] board, int row, int col, (int row, int col) kingPosition)
		{
			return row == kingPosition.row || col == kingPosition.col;
		}

		private static bool CheckPawn(char[][] board, int row, int col, (int row, int col) kingPosition)
		{
			return row == kingPosition.row + 1 && (col == kingPosition.col - 1 || col == kingPosition.col + 1);
		}

		private static bool CheckNight(char[][] board, int row, int col, (int row, int col) kingPosition)
		{
			return
				(row == kingPosition.row + 1 && col == kingPosition.col - 2) ||
				(row == kingPosition.row + 2 && col == kingPosition.col - 1) ||

				(row == kingPosition.row - 1 && col == kingPosition.col - 2) ||
				(row == kingPosition.row - 2 && col == kingPosition.col - 1) ||

				(row == kingPosition.row - 1 && col == kingPosition.col + 2) ||
				(row == kingPosition.row - 2 && col == kingPosition.col + 1) ||

				(row == kingPosition.row + 1 && col == kingPosition.col + 2) ||
				(row == kingPosition.row + 2 && col == kingPosition.col + 1);
		}

		private static (int row, int col) FindKingPosition(char[][] board)
		{
			for (var row = 0; row < BoardSize; row++)
			{
				for (var col = 0; col < BoardSize; col++)
				{
					if (board[row][col] == King)
					{
						return (row, col);
					}
				}
			}

			return (-1, -1);
		}
	}
}
